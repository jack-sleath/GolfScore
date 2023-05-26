namespace GolfScore.Models
{
    public class Course
    {
        public string ExternalID { get; set; }
        public string Name { get; set; }
        public Location? Coordinates { get; set; }
        public bool IsReal { get; set; }
        public bool IsOfficial { get; set; }
        public List<Hole> Holes { get; set; } = new List<Hole>();
        public Dictionary<Guid, DateTime> Editors { get; private set; } = new Dictionary<Guid, DateTime>();
        public void AddEditor(Guid PlayerId, DateTime editDateTime)
        {
            Editors.Add(PlayerId, editDateTime);
        }

    }
}
