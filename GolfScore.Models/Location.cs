namespace GolfScore.Models
{
    public class Location
    {
        public double Longitude { get; private set; }
        public double Latitude { get; private set; }
        public string? Name { get; private set; }
        public Location(double longitude, double latitude, string? name = null)
        {
            Longitude = longitude;
            Latitude = latitude;
            Name = name;
        }
    }
}
