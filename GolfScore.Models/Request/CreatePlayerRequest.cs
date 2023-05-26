namespace GolfScore.Models.Request
{
    public class CreatePlayerRequest
    {
        public string Name { get; set; }
        public string EmojiIdentifier { get; set; }
        public string EmojiAuth { get; set; }
        public string UniqueIdentifier { get; set; }
    }
}
