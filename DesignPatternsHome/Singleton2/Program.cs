using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton2
{
    /*
     * What is Non-Lazy OR Eager Loading
     * The Eager loading in the singleton design pattern is nothing but
     * a process in which we need to initialize the singleton object at the time of application start-up rather than 
     * on-demand and keep it ready in memory to be used in the future. 
     * The advantage of using Eager Loading in the Singleton design pattern is that the CLR (Common Language Runtime) 
     * will take care of object initialization and thread safety. 
     * That means we will not require to write any code explicitly for handling the thread safety for a multithreaded environment.
     * 
     * 
     * 
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentDetails()
                );
        }

        private static void PrintTeacherDetails()
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }

        private static void PrintStudentDetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
