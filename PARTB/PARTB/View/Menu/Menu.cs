using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.View.Menu
{
    public static class Menu
    {
        const int first = -45;
        const int second = -50;
        const int third = -45;
        const int fourth = -50;
        public static void ShowMenu()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------Main Menu---------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{"---------Reading Students Details---------",first}{"---------Reading Trainers Details---------",second}{"---------Reading Assigments Details---------",third}{"---------Reading Course Operations And Exit Option---------",fourth}");
            Console.WriteLine($"{"Press 1 - Read Students",first}{"Press 2 - Read Trainers ",second}{"Press 3 - Read Assigments",third}{"Press 4 - Read Courses",fourth}");
            Console.WriteLine($"{"Press 5 - Read Students Per Course",first}{"Press 6 - Read Trainers Per Course",second}{"Press 7 - Read Assigments Per Course",third}{"Press 8 - To Create a student",fourth}");
            Console.WriteLine($"{"Press 9 - Create Trainer",first}{"Press 10 - Create Course",second}{"Press 11 - Create Assigment",third}{"Press <e> or <E> to exit the program",fourth}");
        }
    }
}
