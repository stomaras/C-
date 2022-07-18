using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sngleton1
{
    public sealed class School
    {
        private static int counter = 0;
        private static readonly object Instancelock = new object(); 
        private static School instance = null;

        public static School GetInstance
        {
            get
            {
                // Double Checking in order not executed one thread at a time
                if (instance == null)
                {
                    lock (Instancelock)
                    {
                        if (instance == null)
                        {
                            instance = new School();
                        }
                    }
                }
                return instance;
            }
        }

        private School()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
