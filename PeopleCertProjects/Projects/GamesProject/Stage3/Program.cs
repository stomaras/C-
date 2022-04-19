using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage3
{
    delegate bool IsDeserveToBuy(Game game);
    class Program
    {
        
        static void Main(string[] args)
        {
            Shop vintageGamesLtd = new Shop()
            {
                ID = 1,
                Name = "Vintage Games Ltd",
                Games = new List<Game>()
                {
                    new Game()
                    {
                        ID = 1,
                        Title = "Pac-Man",
                        Price = 5.00M,
                        Rating = 3,
                        ReleaseDate = new DateTime(1980, 6, 30)
                    },
                    new Game()
                    {
                        ID = 2,
                        Title = "Tomb Raider 2",
                        Price = 7.00M,
                        Rating = 2,
                        ReleaseDate = new DateTime(1997,6,30)
                    },
                    new Game()
                    {
                        ID = 3,
                        Title = "Tomb Raider 3",
                        Price = 8.00M,
                        Rating = 4,
                        ReleaseDate = new DateTime(1998,6,30)
                    }
                }
            };


            Console.WriteLine("Deciding to buy games based on rating:\n");
            Customer customer = new Customer();
            customer.BuyGames(vintageGamesLtd.Games, g => g.Rating > 3);

            Console.WriteLine("Deciding to buy games based on price:\n");
            customer.BuyGames(vintageGamesLtd.Games, g => g.Price < 40);
        }
    }
}
