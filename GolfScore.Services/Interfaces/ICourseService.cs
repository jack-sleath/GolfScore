using GolfScore.Models;
using GolfScore.Models.Request;

namespace GolfScore.Services.Interfaces
{
    public interface ICourseService
    {
        Course CreateCourse(CreateCourseRequest request);
    }
}
