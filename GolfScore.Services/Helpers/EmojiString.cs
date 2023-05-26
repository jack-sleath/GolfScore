using System.Text.RegularExpressions;

namespace GolfScore.Services.Helpers
{
    public static class EmojiString
    {
        private static readonly Regex emojiChecker = new Regex("(\u00a9|\u00ae|[\u2000-\u3300]|\ud83c[\ud000-\udfff]|\ud83d[\ud000-\udfff]|\ud83e[\ud000-\udfff])");
        public static bool ValidProfile(string textToCheck)
        {
            //TODO: also check if its just 1 emoji
            return emojiChecker.IsMatch(textToCheck);
        }

        //public static int HowManyMatches(string textToCheck)
        //{
        //    var matches = emojiChecker.Matches(textToCheck);
        //    return matches.Count();
        //}
    }
}
