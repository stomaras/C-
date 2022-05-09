using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeServiceConsole
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            /*
             * candidate < 0 ----> false
             * candidate = 1 ----> false
             */
            var m = candidate / 2;
            if (candidate < 2)
            {
                return false;
            }



            for (int i = 2; i < m; i++)
            {
                // find a number which divide candidate so is not prime
                if(candidate % i == 0)
                {
                    return false;
                }
            }
            return true;

            throw new NotImplementedException("Please create a test first");
        }
    }
}






