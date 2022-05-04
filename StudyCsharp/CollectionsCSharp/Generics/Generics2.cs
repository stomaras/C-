using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    // dynamic is a new keyword in c#
    // the datatype of the variable is identify in 
    // runtime
    // var is similar to dynamic, but var identifies the type 
    // at compilation time and dynamic identifies the type 
    // at runtime
    // var -> identifies type at compilation time
    // dynamic -> identifies type at runtime
    class Generics2<T>
    {
        public void Add(T a, T b)
        {
            
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }

        public void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }

        public void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }

        public void Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
    }
}
