using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartBNew.Services
{
    class MenuService
    {
        /// <summary>
        /// This method decide which option to select in order to show in the console
        /// </summary>
        /// <returns></returns>
        public static bool Menu()
        {
            int choice;
            PrintService.EnterMenuOptions();
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 12)
            {
                return false;
            }
            else if (choice == 1)
            {
                ConsoleService.ConsoleInputStudent();
            }
            else if (choice == 2)
            {
                ConsoleService.ConsoleInputTrainer();
                
            }
            else if (choice == 3)
            {
                
            } else if(choice == 6)
            {
                PrintService.PrintTrainers();
            }
            return true;
        }

        

    }


}
