using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoProject.Services;

namespace KinoProject.Services
{
    class DrawNumbersGeneration
    {
        public List<int> RandomNumbersGeneration{ get; private set; }

        public DrawNumbersGeneration()
        {
            RandomNumbersGeneration = new List<int>();
            List<int> kinoNumbers = AddKinoNumbers(RandomNumbersGeneration);
            PrintRandomNumbersGeneration(kinoNumbers);
        }

        public List<int> AddKinoNumbers(List<int> RandomNumbersGeneration)
        {
            for (int i = 0; i <= 9; i++)
            {
                int num;
                bool isUnique = false;
                if (i == 0)
                {
                    num = RandomService.Number(1, 80);
                    RandomNumbersGeneration.Add(num);
                }
                if(i > 0)
                {
                   
                    while (!isUnique)
                    {
                        
                        num = RandomService.Number(1, 80);
                        isUnique = CheckUniqueNumber(num, RandomNumbersGeneration);
                        if (isUnique)
                        {
                            RandomNumbersGeneration.Add(num);
                        }
                        
                    }
                    
                }
            }
            return RandomNumbersGeneration;
        }

        public bool CheckUniqueNumber(int number, List<int> RandomNumbersGeneration)
        {
           
            for(int i=0; i <= RandomNumbersGeneration.Count -1; i++)
            {
                if(RandomNumbersGeneration[i] == number)
                {
                    return false;
                }
            }
            return true;
        }

        public static void PrintRandomNumbersGeneration(List<int> RandomNumbersGeneration)
        {
            Console.WriteLine("Kino Numbers:\n");
            for(int i=0; i<= RandomNumbersGeneration.Count-1; i++)
            {
                if(i == 0)
                {
                    Console.WriteLine($"{i+1}st Kino Number {RandomNumbersGeneration[i]}\n");
                }
                if (i == 1)
                {
                    Console.WriteLine($"{i+1}nd Kino Number {RandomNumbersGeneration[i]}\n");
                }
                if(i == 2)
                {
                    Console.WriteLine($"{i+1}rd Kino Number {RandomNumbersGeneration[i]}\n");
                }
                if(i == 3)
                {
                    Console.WriteLine($"{i+1}th Kino Number {RandomNumbersGeneration[i]}\n");
                }
                else if(i >= 4)
                {
                    Console.WriteLine($"{i+1}th Kino Number {RandomNumbersGeneration[i]}\n");
                }
                
            }
            
        }
    }
}
