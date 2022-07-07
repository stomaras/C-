using CodeWarsConsole.Controllers;
using CodeWarsConsole.Enums;
using CodeWarsConsole.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsConsole
{
    public class CodeWars
    {
        public void start()
        {
            string input = "";

            bool isNumber = false;
            ConsoleHelper consoleHelper = new ConsoleHelper();
            while (input != "e" && input != "E")
            {
                const int first = -45;
                const int second = -50;
                const int third = -45;
                const int fourth = -50;

                Console.WriteLine("------------------------Code Wars Tasks------------------------------------");
                Console.WriteLine($"{"Press 1 Convert StringToNumber", first}{"Press 2 Capitalize A Word",second}{"Press 3 something else",third}{"Press 4 something else",fourth}");
                Console.WriteLine("Choose an option!");
                input = Console.ReadLine();
                isNumber = consoleHelper.CheckIfIsNumber(input);
                if (isNumber)
                {
                    CodeWarsController codeWarsController = new CodeWarsController();

                    int inputNumber = Convert.ToInt32(input);
                    Console.Clear();

                    Choice choice = (Choice)inputNumber;

                    switch (choice)
                    {
                        case Choice.ConvertStringToNumber:codeWarsController.ConvertStringToNummber();break;
                        case Choice.CapitalizeWord:codeWarsController.CapitalizeWord();break;
                        case Choice.ConvertBooleanToString:codeWarsController.ConvertBooleanToString();break;
                        default:codeWarsController.ErrorService();
                            break;
                    }
                }
                else
                {
                    if (input != "e" && input != "E")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Press a <<number>> or <<e>> or <<E>> to exit the programm...");
                        Console.ResetColor();
                    }
                }
            }
            Console.WriteLine("Code Wars Game Ends for today...");
        }
    }
}
