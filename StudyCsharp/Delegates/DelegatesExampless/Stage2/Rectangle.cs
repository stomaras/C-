using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage2
{
    
    class Rectangle
    {
        public static void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area of " + Width * Height);
        }

        public static void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter of " + 2 * (Width + Height));
        }

    }
}
