using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm1
{
    /*
     * When i have sample of 30 items.
     * 
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] p = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30};
            //Method(p);// o(1)
            //Method1(p);// o(n)
            //Method2(p);// o(n^2)
            Method3(p);
        }
        /*
         * If data is independent from the Method 
         * This Method will do one thing with o(1) Complexity.
         * O(1) means either 1 element in array or 1.000.000 on array only one
         * thing will done in Method
         * 
         */
        //public static void Method(int[] p)
        //{
        //    Console.WriteLine("ka a"); //O(1) ---> Complexity
        //    Console.WriteLine("ka a");
        //    Console.WriteLine("ka a");
        //}
        //public static void Method1(int[] p)
        //{
        //    for (int i = 0; i < p.Length; i++)// 0(n) ---> Complexity
        //    {
        //        Console.WriteLine("kalimera");
        //    }
        //}
        ///*
        // * 1000 Employees --> 1.000.000 Loops bad !!!
        // * 100 Users same time ---> Server with problem
        // * Really high complexity.
        // */
        //public static void Method2(int[] p)
        //{
        //    for (int i = 0; i < p.Length; i++)// 0(n^2) ---> Complexity.
        //    {
        //        for (int j = 0; j < p.Length; j++)
        //        {
        //            Console.WriteLine("Good Morning!");
        //        }
        //    }
        //}



        public static void Method3(int[] p)
        {
            for (int i = 1; i < p.Length; i=i*2)
            {
                Console.WriteLine("Kalimera");
            }
        }
    }
}
