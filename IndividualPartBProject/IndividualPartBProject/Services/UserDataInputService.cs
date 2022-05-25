using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualPartBProject.Models;
using IndividualPartBProject.Services;

namespace IndividualPartBProject.Services
{
    class UserDataInputService
    {

        public UserDataInputService()
        {

        }

        public static void Options()
        {
            Console.WriteLine("Private School Start:\n");
            Console.WriteLine("Press 1 To Enter Assigment Details:\n");
            Console.WriteLine("Press 2 To Enter Course Details:\n");
            Console.WriteLine("Press 3 To Enter Student Details:\n");
            Console.WriteLine("Press 4 To Enter Trainer Details:\n");
            Console.WriteLine("Press 0 To Exit The Program:\n");
        }

        
    }
}
