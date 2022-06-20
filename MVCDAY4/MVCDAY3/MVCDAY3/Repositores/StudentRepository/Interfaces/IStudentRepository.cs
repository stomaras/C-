using MVCDAY3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDAY3.Repositores.StudentRepository.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();

        Student GetStudent(int? id);

        void DeleteStudent(Student student);

        void AddStudent(Student student);
    }
}
