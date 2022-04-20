using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage2
{
    public delegate void RectDelegate(double Width, double Height);
    class Program
    {
        static void Main(string[] args)
        {
            // We can do a binding of two delegates
            RectDelegate obj = new RectDelegate(Rectangle.GetArea);
            obj += new RectDelegate(Rectangle.GetPerimeter);
            obj.Invoke(2, 3);
            
            
        }
    }
}

/* In Multi-Cast Delegate a delegate will hold the reference of more than
 * 1 method. In a class if we have multiple methods with the same signature
 * we are going to call all these methods with the same delegate
 */
