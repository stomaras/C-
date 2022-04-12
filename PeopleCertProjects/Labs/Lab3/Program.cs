using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        private static char symbol;
        private static int result;
        private static int result2;
        private static int gdc;

        static void Main(string[] args)
        {
            // 1st Question
            Console.Write("Enter 1st number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int number2 = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Enter a symbol:");
                symbol = Convert.ToChar(Console.ReadLine());
                Console.WriteLine($"Symbol {symbol}");
            } while ((symbol != '*') && (symbol != '-') && (symbol != '+') && (symbol != '/') && (symbol != '%') && (symbol != '^'));
            Console.WriteLine($"Symbol {symbol}");

            // 2nd Question
            switch (symbol)
            {
                case '*':
                    result = number1 * number2;
                    result2 = result * result;
                    break;
                case '-':
                    result = number1 - number2;
                    result2 = result - result;
                    break;
                case '+':
                    result = number1 + number2;
                    result2 = result + result;
                    break;
                case '/':
                    result = number1 / number2;
                    result2 = result / result;
                    break;
                case '^':
                    result = number1 ^ number2;
                    result2 = result ^ result;
                    break;
                case '%':
                    result = number1 % number2;
                    result2 = result % result;
                    break;
            }
            Console.WriteLine("Result is : {0} {1} {2} = {3}", number1, symbol ,number2, result);

            // 3rd Question
            
            CheckPrime(result2);
            gdc = GreatestCommonDivisor(result, result2);
            Console.WriteLine($"Greatest Common divisor of {result}, {result2} is: {gdc}");


        }

        public static void CheckPrime(int n)
        {
            int i, m = 0, flag = 0;
            m = n / 2;
            if(n==0 || n == 1)
            {
                Console.WriteLine(n + "is not a prime number");
            } else
            {
                for(i=2; i<=m; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(n + " is not a prime number");
                        flag = 1;
                        break;
                    }
                }
                if(flag == 0)
                {
                    Console.WriteLine(n + " is prime number");
                }
            }
        }

        public static int GreatestCommonDivisor(int result1, int result2)
        {
            int max = 1;
            if(result1 >= result2)
            {
                for(int i=1; i<= result1; i++)
                {
                    if((result1 % i == 0) && (result2 % i == 0))
                    {
                        max = i;
                    }
                }
            } else if(result1 < result2)
            {
                for(int j=1; j<= result2; j++)
                {
                    if((result1 % j == 0) && (result2 % j == 0))
                    {
                        max = j;
                    }
                }
            }
            return max;
        }
    }
}
