namespace GolfScore.Models
{
    public class Match
    {
        public DateTime PlayedDate { get; private set; }
        public List<Player> Players { get; private set; } = new List<Player>();
        public List<Game> Games { get; private set; } = new List<Game>();
        public Guid CourseId { get; private set; }


    }
}
