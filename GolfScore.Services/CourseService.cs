using GolfScore.Exceptions;
using GolfScore.Models;
using GolfScore.Models.Request;
using GolfScore.Repositories.Interfaces;
using GolfScore.Services.Interfaces;

namespace GolfScore.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courserepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courserepository = courseRepository;
        }

        public Course AddHoles(Guid courseId, List<Hole> holes)
        {
            throw new NotImplementedException();
        }

        public Course CreateCourse(CreateCourseRequest request)
        {
            if (string.IsNullOrEmpty(request.Name))
            {
                throw new SaveException(new KeyValuePair<string, string>("Name", "The name is a required field"));
            }

            var course = Course.Create(request.Name, request.ExternalId, request.IsFictional, request.Coordinates);

            Task.Run(async () => await _courserepository.UpsertAsync(course));

            return course;
        }
    }
}
