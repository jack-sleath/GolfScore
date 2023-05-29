namespace GolfScore.Models
{
    public class Course
    {
        public string? ExternalId { get; private set; }
        public string Name { get; private set; }
        public Location? Coordinates { get; private set; } = null;
        public bool IsFictional { get; private set; }
        public bool IsVerified { get; private set; } = false;
        public List<Hole> Holes { get; private set; } = new List<Hole>();
        public Dictionary<Guid, DateTime> Editors { get; private set; } = new Dictionary<Guid, DateTime>();
        public Course(string name, bool isFictional, string externalId = null)
        {
            Name = name;
            ExternalId = externalId;
            IsFictional = isFictional;
        }
        public void AddEditor(Guid PlayerId, DateTime editDateTime)
        {
            Editors.Add(PlayerId, editDateTime);
        }

        public void VerifyCourse()
        {
            IsVerified = true;
        }
    }
}
