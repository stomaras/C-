using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrivateSchoolAPI.DTOS;

namespace PrivateSchoolAPI.Controllers
{
    [Route("api/courses/{courseId}/students")]
    [ApiController]
    public class CoursesController : ControllerBase
    {

       

        [HttpGet]
        public ActionResult<IEnumerable<StudentDTO>> GetStudentsPerCourse(int courseId)
        {
            var course = SchoolDataStore.Current.Courses.FirstOrDefault(c => c.Id == courseId);
            IEnumerable<StudentDTO> students = SchoolDataStore.Current.Students;
            if (course == null)
            {
                return NotFound();
            }

            var studentsPerCourse = new List<StudentDTO>();
            foreach (var student in students)
            {
                if (student.CourseDTO.Id.Equals(courseId))
                {
                    studentsPerCourse.Add(student);
                }
            }
            return Ok(studentsPerCourse);

        }

        [HttpGet("{studentId}")]
        public ActionResult<StudentDTO> GetStudentPerCourse(int studentId, int courseId)
        {
            var course = SchoolDataStore.Current.Courses.FirstOrDefault(c => c.Id == courseId);
            if (course is null)
            {
                return NotFound();
            }

            var student = SchoolDataStore.Current.Students.FirstOrDefault(c => c.Id == studentId);
            if (student is null)
            {
                return NotFound();
            }

            var students = SchoolDataStore.Current.Students;
            foreach (var item in students)
            {
                if (item == student)
                {
                    if (item.CourseDTO.Id == courseId)
                    {
                        return Ok(item);
                    }
                }
            }

            return NotFound();
        }
    }
}
