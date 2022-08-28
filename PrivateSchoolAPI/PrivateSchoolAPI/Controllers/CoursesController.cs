using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrivateSchoolAPI.DTOS;
using PrivateSchoolAPI.Entities;

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
            if (course == null)
            {
                return NotFound();
            }

            IEnumerable<Student> students = SchoolDataStore.Current.Students;
            var studentsPerCourse = new List<StudentDTO>();
            foreach (var student in students)
            {
                if (student.Course.Id.Equals(courseId))
                {
                    StudentDTO studentDTO = new StudentDTO()
                    {
                        Id = student.Id,
                        FirstName = student.FirstName,
                        LastName = student.LastName,
                        Age = student.Age,
                        CourseName = student.Course.Name
                    };
                    studentsPerCourse.Add(studentDTO);
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
            foreach (var stu in students)
            {
                if (stu.Id == student.Id)
                {
                    if (student.Course.Id == courseId)
                    {
                        StudentDTO stuDTO = new StudentDTO()
                        {
                            Id = stu.Id,
                            FirstName = stu.FirstName,
                            LastName = stu.LastName,
                            Age = stu.Age,
                            CourseName = stu.Course.Name,
                        };

                        return Ok(stuDTO);
                    }
                }
            }

            return NotFound();
        }

        //[HttpPost]
        //public ActionResult<CourseForCreationDTO> CreateStudent(int courseId,
        //    [FromBody] StudentForCreationDTO studentForCreationDTO)
        //{
        //    var student = SchoolDataStore.Current.Courses.FirstOrDefault(c => c.Id == courseId);
        //    if (student is null)
        //    {
        //        return NotFound();
        //    }

        //    // demo purposes
        //    var maxPointOfInterestId = SchoolDataStore.Current.Courses.SelectMany(c=>c.S)
        //}
    }
}
