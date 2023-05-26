namespace GolfScore.Models
{
    public class Player
    {
        public string Name { get; private set; }
        public string EmojiIdentifier { get; private set; }
        public string EmojiAuth { get; private set; }
        public string UniqueIdentifier { get; private set; }
        public int OfficialRating { get; set; }
        public int UnofficialRating { get; set; }
        public List<Game> Games { get; private set; } = new List<Game>();
        public int GameCount
        {
            get
            {
                return Games.Count;
            }
        }

        public Player(string name, string emojiIdentifier, string emojiAuth, string uniqueIdentifier)
        {
            Name = name;
            EmojiIdentifier = emojiIdentifier;
            EmojiAuth = emojiAuth;
            UniqueIdentifier = uniqueIdentifier;

        }

        public void AddGame(Game game)
        {
            Games.Add(game);
        }
    }
}