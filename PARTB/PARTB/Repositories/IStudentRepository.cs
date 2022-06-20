using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Repositories
{
    public interface IStudentRepository
    {
        void Add(Student student);
        Student GetStudentById(int id);

        List<Student> GetAllStudents();


        
        void ReadStudents(List<Student> students);
    }
}
