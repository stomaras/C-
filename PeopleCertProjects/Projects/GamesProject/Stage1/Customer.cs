using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1
{
    class Customer
    {
        public int ID { get; set; }
        public string FullName { get; set; }

        // association
        public void BuyGames(List<Game> games)
        {
            foreach(var game in games)
            {
                if(game.Rating > 3)
                {
                    Console.WriteLine(game.Title + " sold!");
                }
            }
        }
    }
}
