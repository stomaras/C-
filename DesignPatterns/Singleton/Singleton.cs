using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /*
     * Sealed restricts the inheritance
     */
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        /*
         * Private constructor ensures that object is not
         * instantiated other than with in the class itself
         * 
         */
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value " + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
