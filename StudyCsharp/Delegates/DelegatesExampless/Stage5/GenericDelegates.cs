using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage5
{
    
    class GenericDelegates
    {

        public static double AddNums1(int x, float y, double z)
        {
            return x + y + z;
        }

        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }

        public static bool CheckLength(string str)
        {
            if (str.Length > 5)
                return true;
            return false;
        }
    }
}
