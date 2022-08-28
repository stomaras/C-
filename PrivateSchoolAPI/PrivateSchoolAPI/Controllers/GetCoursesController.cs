using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrivateSchoolAPI.DTOS;

namespace PrivateSchoolAPI.Controllers
{
    [Route("api/courses/")]
    [ApiController]
    public class GetCoursesController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<CourseDTO>> GetCourses()
        {
            var courses = SchoolDataStore.Current.Courses;
            return Ok(courses);
        }

        [HttpGet("{courseId}")]
        public ActionResult<CourseDTO> GetCourse(int courseId)
        {
            var course = SchoolDataStore.Current.Courses.FirstOrDefault(c => c.Id == courseId);
            if (course is null)
            {
                return NotFound();
            }

            return Ok(course);
        }
    }
}
