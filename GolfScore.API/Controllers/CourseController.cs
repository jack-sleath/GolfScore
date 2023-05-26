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
        public IActionResult CreateMatch(CreateCourseRequest request)
        {
            return HandleCreate(() => _courseService.CreateCourse(request));
        }
    }
}
