using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoProject.Services;

namespace KinoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Options();
            UserDataInputService userDataInputService = new UserDataInputService();
            bool KinoBonus = userDataInputService.KinoBonus;
            DrawNumbersGeneration drawNumbersGeneration = new DrawNumbersGeneration(KinoBonus);
            List<int> KinoNumbers = drawNumbersGeneration.RandomNumbersGeneration;
            List<int> UserNumbers = userDataInputService.KinoNumbers;
            
            ListComparisonService listComparisonService = new ListComparisonService(UserNumbers, KinoNumbers);
            listComparisonService.CheckMatches(UserNumbers, KinoNumbers, KinoBonus);
            
        }
        public static void Options()
        {
            Console.WriteLine("Enter 6 numbers at total:\n");
            Console.WriteLine("Enter A number between: 1-80\n");
        }
    }
}
