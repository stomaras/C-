using PARTB.Database;
using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private ApplicationContext db;
        public StudentRepository(ApplicationContext context)
        {
            db = context;
        }
        public void Add(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllStudents()
        {
            var students = db.Students.ToList();
            if (students == null)
            {
                throw new NotImplementedException("Students Does Not Exists In Database!!!");
            }
            return students;

        }

        

        public Student GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public void ReadStudents(List<Student> students)
        {
            throw new NotImplementedException();
        }
    }
}
