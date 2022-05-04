using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Generics1
    {

        public bool Compare(int a, int b)
        {
            if(a == b)
            {
                return true;

            } else
            {
                return false;
            }
        }

        // I MAKE Compare method type safe
        // with the use of Generic, this T consider as placeholder
        public bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
