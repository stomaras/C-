using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrivateSchoolAPI.DTOS;
using PrivateSchoolAPI.Entities;

namespace PrivateSchoolAPI.Controllers
{
    [Route("api/courses/")]
    [ApiController]
    public class GetCoursesController : ControllerBase
    {

        [HttpGet(Name ="GetCourses")]
        public ActionResult<IEnumerable<CourseDTO>> GetCourses()
        {
            var courses = SchoolDataStore.Current.Courses;
            IEnumerable<CourseDTO> coursesDTO = new List<CourseDTO>() { };

            foreach (var course in courses)
            {
                CourseDTO newCourseDTO = new CourseDTO()
                {
                    Id = course.Id,
                    Name = course.Name,
                    Stream = course.Stream,
                    StartDateTime = course.StartDateTime,
                    EndDateTime = course.EndDateTime,
                };
                coursesDTO.Append(newCourseDTO);
            }
            return Ok(coursesDTO);
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

        [HttpGet(Name = "GetCourse")]
        public ActionResult<CourseDTO> ReturnCourse(int courseId)
        {
            var course = SchoolDataStore.Current.Courses.FirstOrDefault(c => c.Id == courseId);
            if (course is null)
            {
                return NotFound();
            }

            CourseDTO courseDTO = new CourseDTO()
            {
                Id = course.Id,
                Name = course.Name,
                Stream = course.Stream,
                StartDateTime = course.StartDateTime,
                EndDateTime = course.EndDateTime
            };

            return courseDTO;
        }

        [HttpPost]
        public ActionResult<Course> CreateCourse(CourseForCreationDTO courseForCreation)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var maxCourseId = SchoolDataStore.Current.Courses.Max(c => c.Id);

            var finalCourse = new Course()
            {
                Id = ++maxCourseId,
                Name = courseForCreation.Name,
                Stream = courseForCreation.Stream,
                StartDateTime = courseForCreation.StartDateTime,
                EndDateTime = courseForCreation.EndDateTime,
            };
            if (finalCourse == null)
            {
                return NotFound();
            }
            var courses = SchoolDataStore.Current.Courses;

            courses.Add(finalCourse);

            return CreatedAtRoute("GetCourse",
                    new
                    {
                        courseId = finalCourse.Id
                    },
                    finalCourse
                );

        }
    }
}
