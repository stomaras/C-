using MVCDay2Begin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDay2Begin.Repositories.StudentRepository
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();

        Student GetStudent(int? id);

        void DeleteStudent(Student student);
    }
}
