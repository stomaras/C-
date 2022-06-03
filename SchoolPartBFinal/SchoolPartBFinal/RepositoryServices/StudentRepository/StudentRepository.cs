using SchoolPartBFinal.Database;
using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
using SchoolPartBFinal.FactoryObjects;

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
            List<Student> studentsList = Factory.CreateStudentsList();
            using (var db = new ApplicationContext())
            {
                studentsList = db.Students.SqlQuery("SELECT * FROM Students").ToList<Student>();
            }
            return studentsList;
        }

        public Student GetStudentById(int id)
        {
            Student student = Factory.CreateStudent();
            using (var db = new ApplicationContext())
            {
                student = db.Students.SqlQuery("SELECT * FROM Students WHERE StudentId=@id", new SqlParameter("@id", 1)).FirstOrDefault();
            }
            return student; 
        }

        public Student UpdateStudent(Student student)
        {
            
            
            Student studentToUpdate = null;
            using (var db = new ApplicationContext())
            {
                List<Student> students = db.Students.ToList();
                int count = 0;
                for (int i = 0; i <= students.Count-1; i++)
                {
                    
                    if (student.StudentId == students[i].StudentId)
                    {
                        
                        count++;
                        string newFirstName = student.FirstName;
                        string newLastName = student.LastName;
                        int id = student.StudentId;
                        var sql = @"UPDATE [Students] SET FirstName = @FirstName, LastName = @LastName WHERE StudentId = @StudentId";
                        db.Database.ExecuteSqlCommand(sql, new SqlParameter("@FirstName", newFirstName), new SqlParameter("@LastName", newLastName), new SqlParameter("@StudentId",id));
                        
                        studentToUpdate = Factory.CreateStudent(id,newFirstName, newLastName);
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine("dssdgiatii");
                    return null;
                }
            }
            return studentToUpdate;
        }

        
    }
}
