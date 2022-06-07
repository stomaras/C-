using SchoolPartBFinal.Entities;
using SchoolPartBFinal.RepositoryServices.StudentRepository;
using SchoolPartBFinal.Views.StudentView;
using SchoolPartBFinal.GeneralServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal.Controller
{
    public class StudentController
    {
        public void ReadingStudent()
        {
            try
            {
                StudentRepository rep = new StudentRepository();// Back End
                PrintStudent pr = new PrintStudent();
                var students = rep.GetAll();
                pr.PrintStudents(students);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReadStudentBasedOnId()
        {
            try
            {
                StudentRepository rep = new StudentRepository();// Back End
                InputStudent input = new InputStudent();
                PrintStudent pr = new PrintStudent();
                int studentId = input.EnterStudentIdToRead();
                var student = rep.GetStudentById(studentId);
                pr.PrintAStudent(student);

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CreateStudent()
        {
            try
            {
                StudentRepository rep = new StudentRepository();
                InputStudent input = new InputStudent();
                PrintStudent pr = new PrintStudent();

                var student = input.EnterStudentToCreate();
                string message = rep.CreateStudent(student);
                pr.PrintStudentSuccessCreateMessage(message);
               
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateStudent()
        {
            try
            {
                StudentRepository rep = new StudentRepository();
                InputStudent input = new InputStudent();
                PrintStudent pr = new PrintStudent();
                string message = "";
                Student studentToUpdate = input.EnterStudentDetailsToUpdate();
                Student stu = rep.UpdateStudent(studentToUpdate);
                if (stu != null)
                {
                    message = $"Student Updated With New First Name {stu.FirstName} With New Last Name {stu.LastName} With New Date Of Birth {stu.BirthDate} With New Tuition Fees {stu.TuitionFees}";
                    pr.PrintStudentSuccessUpdateMessage(message);
                }
                else
                {
                    message = $"Student does not exists";
                    pr.PrintStudentFailureUpdateMessage(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteStudent()
        {
            try
            {
                StudentRepository rep = new StudentRepository();
                InputStudent input = new InputStudent();
                PrintStudent pr = new PrintStudent();
                int studentId = input.EnterStudentIdToDelete();
                
                List<int> studentIds = rep.GetAllStudentsIds();
                bool studentToDeleteExists = rep.CheckIfStudentIdExists(studentIds, studentId);
                
                if (studentToDeleteExists)
                {
                    Console.WriteLine(studentId);
                    Student studentToDelete = rep.DeleteStudent(studentId);
                    string successDeleteMessage = $"Student with id {studentToDelete.StudentId}, with student name {studentToDelete.FullName} , with date of birth {studentToDelete.BirthDate} , with tuition fees {studentToDelete.TuitionFees} deleted successfully";
                    pr.PrintStudentSuccessDeleteMessage(successDeleteMessage);
                    
                }
                else
                {
                    string failureDeleteMessage = $"Student with id {studentId} does not exists!";
                    pr.PrintStudentFailureDeleteMessage(failureDeleteMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public void ErrorService()
        {
            Console.WriteLine("Wrong Choice Try Again or Press E (or) e to exit!!!");
        }
    }
}
