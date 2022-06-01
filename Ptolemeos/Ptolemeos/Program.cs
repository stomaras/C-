using Ptolemeos.RepositoryServices.StudentRepository;
using Ptolemeos.Views.StudentView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Services service = new Services();
            while (true)
            {
                Console.WriteLine("1 - Reading All Students");
                Console.WriteLine("2 - Create A Student");
                Console.WriteLine("3 - Edit A Student");
                Console.WriteLine("4 - Delete A Student");
                Console.WriteLine("Choose:");
                Console.ForegroundColor = ConsoleColor.Green;
                string choice = Console.ReadLine();
                Console.ResetColor();

                Console.Clear();
                switch (choice)
                {
                    case "1": service.ReadingService(); break;
                    case "2": service.CreatingService(); break;
                    case "3": service.EditingService(); break;
                    case "4": service.DeleteService(); break;
                    default: service.ErrorService(); break;
                }
            }
        }
    }

    class Services
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
