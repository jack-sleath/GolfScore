namespace GolfScore.Models
{
    public class Score
    {
        public int HoleNumber { get; private set; }
        public int ScoreNumber { get; private set; }

        public Score(int holeNumber, int scoreNumber)
        {
            HoleNumber = holeNumber;
            ScoreNumber = scoreNumber;
        }

        public void UpdateScore(int newScore)
        {
            ScoreNumber = newScore;
        }
    }
}
