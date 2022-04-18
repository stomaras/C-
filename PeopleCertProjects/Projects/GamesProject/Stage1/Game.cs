using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1
{
    class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }
        // with money use decimal
        public decimal Price { get; set; }
        public int Rating { get; set; }
        public DateTime ReleaseDate { get; set; }



        public virtual void Sell()
        {
            Console.WriteLine($"The game with title: {Title} has been sold");
        }
    }
}
