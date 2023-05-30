using GolfScore.Models;
using GolfScore.Models.Request;
using GolfScore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GolfScore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : BaseController
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult CreateCourse(CreateCourseRequest request)
        {
            return HandleCreate(() => _courseService.CreateCourse(request));
        }

        [HttpPatch]
        [Route("/{courseId}/AddHoles")]
        public IActionResult AddHoles(Guid courseId, List<Hole> holes)
        {
            return HandleUpdate(() => _courseService.AddHoles(courseId, holes));
        }
    }
}
