using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal.RepositoryServices.StudentRepository
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student GetStudentById(int id);
        string DeleteStudent(int id);
        Student UpdateStudent(Student student);

        string CreateStudent(Student student);
    }
}
