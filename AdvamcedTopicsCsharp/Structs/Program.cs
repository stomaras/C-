using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    /*
     * structs are value types
     * are passed by value (like integers)
     * cannot have a null reference (unless Nullable is used)
     * Do not have a memory overhead per new instance - unless "boxed"
     * can contain method and events can support interface
     */

    struct Game
    {
        public string Name;
        public string Developer;
        public double Rating;
        public string ReleaseDate;

        public void Display()
        {
            Console.WriteLine("Game 1's name is :{0}", Name);
            Console.WriteLine("Game 1's was developed by :{0}", Developer);
            Console.WriteLine("Game 1's rating is :{0}", Rating);
            Console.WriteLine("Game 1's release date is :{0}", ReleaseDate);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game game1;

            game1.Name = "Pokemon Go";
            game1.Developer = "Niatic";
            game1.Rating = 3.5;
            game1.ReleaseDate = "01.07.2016";

            game1.Display();

            Console.ReadKey();

        }
    }
}
