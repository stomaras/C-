using Ptolemeos.RepositoryServices.StudentRepository;
using Ptolemeos.Views.StudentView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos.Controllers
{
    public class Services
    {
        public void ReadingService()
        {
            try
            {
                StudentRepository rep = new StudentRepository();

                PrintStudent pr = new PrintStudent();
                var students = rep.GetAll();
                pr.PrintStudents(students);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void CreatingService()
        {
            try
            {
                StudentRepository rep = new StudentRepository();// open touch with db
                InputStudent input = new InputStudent();// open touch with input logic

                var student = input.GetStudentData();
                rep.Add(student);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        public void EditingService()
        {
            try
            {
                StudentRepository rep = new StudentRepository();// Back End
                InputStudent input = new InputStudent();// Front End

                var student = input.GetDataForEdit();
                rep.Update(student);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        public void DeleteService()
        {
            try
            {
                StudentRepository rep = new StudentRepository();
                InputStudent input = new InputStudent();

                int id = input.GetIdForDelete();
                rep.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void ErrorService()
        {
            Console.WriteLine("Wrong Choice...");
        }
    }
}
