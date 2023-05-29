namespace GolfScore.Models.Request
{
    public class CreateCourseRequest
    {
        public string? ExternalId { get; set; }
        public string Name { get; set; }
        public Location? Coordinates { get; set; } = null;
        public bool IsFictional { get; set; }
    }
}
