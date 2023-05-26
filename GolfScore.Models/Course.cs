namespace GolfScore.Models
{
    public class Course
    {
        public string ExternalID { get; set; }
        public string Name { get; set; }
        public Location? Coordinates { get; set; }
        public bool IsReal { get; set; }
        public bool IsOfficial { get; set; }

    }
}
