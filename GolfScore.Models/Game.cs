namespace GolfScore.Models
{
    public class Game
    {
        public Guid MatchId { get; private set; }
        public Guid CourseId { get; private set; }
        public Guid PlayerId { get; private set; }
        public List<Score> Scores { get; private set; } = new List<Score>();

        public Game(Guid matchId, Guid courseId, Guid playerId)
        {
            MatchId = matchId;
            CourseId = courseId;
            PlayerId = playerId;
        }
        public void UpdateScore(int holeNumber, int scoreNumber)
        {
            var hole = Scores.FirstOrDefault(hole => hole.HoleNumber == holeNumber);
            if (hole != null)
            {
                hole.UpdateScore(scoreNumber);
                return;
            }
            Scores.Add(new Score(holeNumber, scoreNumber));
        }

        public void SetScore(List<Score> listOfScores)
        {
            Scores = listOfScores;
        }
    }
}
