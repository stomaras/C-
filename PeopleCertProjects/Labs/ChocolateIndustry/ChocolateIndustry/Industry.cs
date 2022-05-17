using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateIndustry.Interfaces;
using ChocolateIndustry.Models;
using ChocolateIndustry.Repository;
using ChocolateIndustry.Services;

namespace ChocolateIndustry
{
    class Industry
    {

        public Industry()
        {

        }

        public void Start()
        {
            
            Console.WriteLine("Enter number between 0-10:\n");
            int action;
            string s = Console.ReadLine();
            action = CheckService.EnterValidNumberBetween0And10(s);
            while (action >= 0 && action <=10)
            {
                switch (action)
                {
                    case 0:
                        // Enter Available Options
                        PrintService.PrintProgramOptions();
                        break;
                    case 1:
                    // Enter Industry Number Of Chocolates
                    default:
                        // Exit the program
                        action = -1;
                        break;
                }
                if(action != -1)
                {
                    
                    s = Console.ReadLine();
                    action = CheckService.EnterValidNumberBetween0And10(s);
                }
            }
            
        }
    }
}
