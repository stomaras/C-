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
using System.Data;

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
                    message = $"Student {{ With First Name {student.FirstName} And Last Name {student.LastName} With birth date {student.BirthDate} With tuition fees {student.TuitionFees}  added to database }}";
                }
                else
                {
                    message = $"Student Does Not Added In Database";
                }
                
            }
            
            return message;
        }

        public List<int> GetAllStudentsIds()
        {
            List<int> studentIDs = Factory.CreateListWithInts();
            using (ApplicationContext db = new ApplicationContext())
            {
                var Students = db.Students.ToList();

                foreach (var student in Students)
                {
                    studentIDs.Add(student.StudentId);
                }
            }
            return studentIDs;
        }

        public bool CheckIfStudentIdExists(List<int> StudentIds, int StudentId)
        {
            bool exists = false;
            for (int i = 0; i <= StudentIds.Count-1; i++)
            {
                
                if (StudentIds[i] == StudentId)
                {
                    
                    exists = true;
                }
            }
            return exists;
            
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
                student = db.Students.SqlQuery("SELECT * FROM Students WHERE StudentId=@id", new SqlParameter("@id", id)).FirstOrDefault();
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
                        DateTime NewDateOfBirth = (DateTime)student.BirthDate;
                        Console.WriteLine(NewDateOfBirth);
                        decimal NewtuitionFees = student.TuitionFees;
                        Console.WriteLine(NewtuitionFees);
                        int id = student.StudentId;
                        var sql = @"UPDATE [Students] SET FirstName = @FirstName, LastName = @LastName, BirthDate = @BirthDate, TuitionFees = @TuitionFees WHERE StudentId = @StudentId";
                        db.Database.ExecuteSqlCommand(sql, new SqlParameter("@FirstName", newFirstName), new SqlParameter("@LastName", newLastName), new SqlParameter("@BirthDate", NewDateOfBirth), new SqlParameter("@TuitionFees", NewtuitionFees) ,new SqlParameter("@StudentId",id));
                        
                        studentToUpdate = Factory.CreateStudent(id,newFirstName, newLastName, NewDateOfBirth, NewtuitionFees);
                    }
                }

                if (count == 0)
                {
                   
                    return null;
                }
            }
            return studentToUpdate;
        }

        public Student DeleteStudent(int id)
        {
           
            StudentRepository studentRepository = Factory.CreateStudentRepositoryObject();
            var studentToDelete = new Student()
            {
                StudentId = id
            };
            Console.WriteLine(id);
            var deleteStudent = studentRepository.GetStudentById(id);
            using (var db = new ApplicationContext())
            {
                var sql = @"DELETE [Students] FROM Students WHERE StudentId=@StudentId";
                db.Database.ExecuteSqlCommand(sql, new SqlParameter("@StudentId", id));

                db.SaveChanges();
            }
            
            return deleteStudent;
        }

        public List<int> GetAllStudentIds()
        {
            List<int> studentIds = Factory.CreateListWithInts();
            using (var db = new ApplicationContext())
            {

                var studentsList = db.Students.SqlQuery("SELECT * FROM Students").ToList<Student>();
                foreach (var stu in studentsList)
                {
                    studentIds.Add(stu.StudentId);
                }
            }
            return studentIds;
        }
    }
}
