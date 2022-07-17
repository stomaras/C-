using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Bank
    {
        public string Name { get; set; } = "Eurobank";

        public List<string> cart { get; set; } = new List<string>();



        // Singleton Design Pattern
        private static object lockObject = new object();
        private static volatile Bank instance;



        public static Bank CreateBank 
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Bank();
                        }
                    }
                }
                return instance;
            }
        } 
        private Bank() {}

        
    }
}
