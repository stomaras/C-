using Microsoft.AspNetCore.Mvc;
using PrivateSchoolAPI.DTOS;

namespace PrivateSchoolAPI.Controllers
{

    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<StudentDTO>> GetStudents()
        {
            var students = SchoolDataStore.Current.Students;
            return Ok(students);
        }


        [HttpGet("{id}")]
        public ActionResult<StudentDTO> GetStudent(int id)
        {
            // find student
            var studentToReturn = SchoolDataStore.Current.Students
                .FirstOrDefault(x=> x.Id == id);

            if (studentToReturn == null)
            {
                return NotFound();
            }

            return Ok(studentToReturn);
        }
    }
}
