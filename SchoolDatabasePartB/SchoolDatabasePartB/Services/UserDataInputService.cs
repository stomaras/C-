using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolDatabasePartB.Database;
namespace SchoolDatabasePartB.Services
{
    public class UserDataInputService
    {
        public UserDataInputService()
        {

        }

        public static Student EnterStudentDetails()
        {
            PrintService.PrintStudentFirstName();
            string firstName = Console.ReadLine();
            PrintService.PrintStudentLastName();
            string lastName = Console.ReadLine();
            string email = Console.ReadLine();
            Student student = new Student();
        }
    }
}
