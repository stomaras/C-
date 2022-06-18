using PARTB.Database;
using PARTB.Repositories;
using PARTB.View.StudentView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Controllers
{
    public class StudentController
    {

        private ApplicationContext db = new ApplicationContext();

        private StudentRepository studentRepository;

        public StudentController()
        {
            studentRepository = new StudentRepository(db);
        }

        public void ReadingStudents()
        {
            try
            {
                PrintStudent pr = new PrintStudent();
                var students = studentRepository.GetAllStudents();
                pr.PrintStudents(students);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CreateStudents()
        {
            try
            {
                PrintStudent pr = new PrintStudent();
                pr.EnterStudentDetailsToCreate();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ErrorService()
        {
            Console.WriteLine("This input does not exists try again or Press E (or) e to exit !!!");
        }
    }
}
