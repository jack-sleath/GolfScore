using System.Globalization;
using System.Text.RegularExpressions;

namespace GolfScore.Services.Helpers
{
    public static class EmojiString
    {
        private static readonly Regex emojiChecker = new Regex("(\u00a9|\u00ae|[\u2000-\u3300]|\ud83c[\ud000-\udfff]|\ud83d[\ud000-\udfff]|\ud83e[\ud000-\udfff])", RegexOptions.Compiled | RegexOptions.IgnoreCase);


        public static bool ValidProfile(string textToCheck)
        {
            //TODO: also check if its just 1 emoji
            var isAllEmoji = emojiChecker.IsMatch(textToCheck);

            Console.WriteLine($"Matches Count {emojiChecker.Matches(textToCheck).Count()}");
            Console.WriteLine($"Runes Count {textToCheck.EnumerateRunes().Count()}");

            //Console.WriteLine($"All Tests {textToCheck.EmojiStringErm()},");

            return isAllEmoji;
        }

        public static bool IsSimpleEmoji(this char character)
        {
            if (!char.IsSurrogate(character))
                return false;

            var unicodeScalar = char.ConvertToUtf32(character.ToString(), 0);
            return CharUnicodeInfo.GetUnicodeCategory(unicodeScalar) == UnicodeCategory.OtherSymbol
                && unicodeScalar > 0x238C;
        }

        public static bool IsCombinedIntoEmoji(this char character)
        {
            var unicodeScalars = character.ToString().Select(c => (int)c).ToArray();
            return unicodeScalars.Length > 1 && unicodeScalars.All(scalar => IsSimpleEmoji((char)scalar));
        }

        public static bool IsEmoji(this char character)
        {
            return character.IsSimpleEmoji() || character.IsCombinedIntoEmoji();
        }

        public static bool IsSingleEmoji(this string str)
        {
            return str.Length == 1 && str[0].IsEmoji();
        }

        public static bool ContainsEmoji(this string str)
        {
            return str.Any(c => c.IsEmoji());
        }

        public static bool ContainsOnlyEmoji(this string str)
        {
            return !string.IsNullOrEmpty(str) && !str.Any(c => !c.IsEmoji());
        }

        public static string EmojiStringErm(this string str)
        {
            return new string(str.Where(c => c.IsEmoji()).ToArray());
        }

        public static char[] Emojis(this string str)
        {
            return str.Where(c => c.IsEmoji()).ToArray();
        }

        public static int[] EmojiScalars(this string str)
        {
            return str.Where(c => c.IsEmoji()).SelectMany(c => c.ToString().Select(ch => (int)ch)).ToArray();
        }
    }
}

