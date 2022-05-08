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
            if(candidate < 2)
            {
                return false;
            }
            if(candidate == 2)
            {
                return true;
            }
            var resultWith1 = candidate / 1;
            var resultWithSelf = candidate / candidate;
            if (resultWith1 == candidate && resultWithSelf == 1)
            {
                return true;
            }
            throw new NotImplementedException("Please create a test first");
            
        }
    }
}
