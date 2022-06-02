using SchoolPartBFinal.Database;
using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SchoolPartBFinal.RepositoryServices.StudentRepository
{
    public class StudentRepository : IStudentRepository
    {
        public string CreateStudent(Student student)
        {
            string message = "";
            using (ApplicationContext db = new ApplicationContext())
            {
                if (student != null)
                {
                    db.Entry(student).State = EntityState.Added;
                    db.SaveChanges();
                    message = $"New Student With First Name {student.FirstName} And Last Name {student.LastName} added to database";
                }
                else
                {
                    message = $"Student Does Not Added In Database";
                }
                
            }
            
            return message;
        }

        public string DeleteStudent(int id)
        {
            Console.WriteLine("Delete A Specific Student From Database");
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            Console.WriteLine("Retrieve All Students From Database");
            throw new NotImplementedException();
        }

        public Student GetStudentById(int id)
        {
            Console.WriteLine("Retrieve A Specific Student From Database");
            throw new NotImplementedException();
        }

        public string UpdateStudent(Student student)
        {
            Console.WriteLine("Update Student In Database");
            throw new NotImplementedException();
        }

        
    }
}
