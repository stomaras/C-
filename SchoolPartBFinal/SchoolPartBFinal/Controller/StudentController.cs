using SchoolPartBFinal.Entities;
using SchoolPartBFinal.RepositoryServices.StudentRepository;
using SchoolPartBFinal.Views.StudentView;
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
                Console.WriteLine($"{studentToUpdate.FirstName}");
                Student stu = rep.UpdateStudent(studentToUpdate);
                if (stu != null)
                {
                    message = $"Student Updated With New First Name {stu.FirstName} With New Last Name {stu.LastName}";
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

                int studentId = input.EnterStudentIdToDelete();
                rep.DeleteStudent(studentId);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void ErrorService()
        {
            Console.WriteLine("Wrong Choice Try Again or Press E (or) e to exit!!!");
        }
    }
}
