using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            int[] array = new int[2000];
            int lengthArray = array.Length;
            for (int i = 0; i <= lengthArray/2; i = i+100)
            {
                Console.WriteLine(i);
            }
            for(int j = 1050; j <= lengthArray; j=j+50)
            {
                Console.WriteLine(j);
            }

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            for(int k = 1; k<=10; k++)
            {
                int multiplier = number * k;
                Console.WriteLine($"{number} * {k} = {multiplier}");
            }

            for(int l=1; l<=12; l++)
            {
                for(int m=1; m<=7; m++)
                {
                    Console.Write(m);
                    Console.Write("  ");
                }
                Console.Write("         ");
                Console.WriteLine(l);
            }
            
        }
    }
}
