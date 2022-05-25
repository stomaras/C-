using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartBNew.Services
{
    class PrintService
    {
        public static void EnterMenuOptions()
        {
            Console.WriteLine("\tMenu:\n");
            Console.WriteLine("\t\t1.Enter Student Details:\n");
            Console.WriteLine("\t\t2.Enter Trainer Details:\n");
            Console.WriteLine("\t\t3.Enter Course Details:\n");
            Console.WriteLine("\t\t4.Enter Assigment Details:\n");
            Console.WriteLine("\t\t5.Print Students:\n");
            Console.WriteLine("\t\t6.Print Trainers:\n");
            Console.WriteLine("\t\t7.Print Courses:\n");
            Console.WriteLine("\t\t8.Print Assigments:\n");
            Console.WriteLine("\t\t9.Print Students Per Course:\n");
            Console.WriteLine("\t\t10.Print Trainers Per Course:\n");
            Console.WriteLine("\t\t11.Print Assigments Per Course:\n");
            Console.WriteLine("\t\t12.Exit Program:\n");
            Console.WriteLine("\t\tGive a choice:\n");
        }

        public static void PrintTrainers()
        {
            Console.WriteLine("Trainers:\n");
            Console.WriteLine(DatabaseInputService.SelectTrainers());
        }
    }
}
