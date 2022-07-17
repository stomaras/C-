using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton2
{
    public sealed class Singleton
    {
        private static int counter = 0;

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value" + counter.ToString());
        }

        // Creates the Singleton instance at the time of application start up.
        private static readonly Singleton Instance = new Singleton();

        public static Singleton GetInstance
        {
            get
            {
                return Instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
