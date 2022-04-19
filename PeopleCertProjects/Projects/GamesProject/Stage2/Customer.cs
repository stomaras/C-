using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage2
{
    class Customer
    {
        public int ID { get; set; }
        public string FullName { get; set; }

        // association
        public void BuyGames(List<Game> games, IsDeserveToBuy isDeserveToBuy)
        {
            foreach (Game game in games)
            {
                if (isDeserveToBuy(game))
                {
                    Console.WriteLine(game.Title + " sold!");
                }
            }
        }
    }
}
