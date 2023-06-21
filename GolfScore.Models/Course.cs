namespace GolfScore.Models
{
    public class Course : BaseCosmosEntity
    {
        public static Course Create(string name, string? externalId, bool isFictional, Location? coordinates = null)
        {
            var entity = BaseCosmosEntity.Create<Course>(typeof(Course).Name);
            entity.ExternalId = externalId;
            entity.Name = name;
            entity.IsFictional = isFictional;
            entity.Coordinates = coordinates;
            return entity;
        }

        public string? ExternalId { get; private set; }
        public string Name { get; private set; }
        public Location? Coordinates { get; private set; } = null;
        public bool IsFictional { get; private set; }
        public bool IsVerified { get; private set; } = false;
        public List<Hole> Holes { get; private set; } = new List<Hole>();
        public Dictionary<Guid, DateTime> Editors { get; private set; } = new Dictionary<Guid, DateTime>();
        public Course()
        {

        }

        public void AddHoles(List<Hole> newHoles) {
            Holes = newHoles;
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
