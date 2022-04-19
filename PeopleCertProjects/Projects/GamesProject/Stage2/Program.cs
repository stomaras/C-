using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage2
{
    delegate bool IsDeserveToBuy(Game game);
    class Program
    {

        static bool BuyBasedOnRating(Game game)
        {
            if (game.Rating > 3)
                return true;
            return false;
        }

        static bool BuyBasedOnPrice(Game game)
        {
            if (game.Price < 40)
                return true;
            return false;
        }
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

            Console.WriteLine("Deciding to buy a game based on Rating..............");
            IsDeserveToBuy isDeserveToBuyBasedOnRating = new IsDeserveToBuy(BuyBasedOnRating);
            

            Customer customer = new Customer()
            {
                ID = 3,
                FullName = "Panos Nikolaidis"
            };

            customer.BuyGames(vintageGamesLtd.Games, isDeserveToBuyBasedOnRating);

            Console.WriteLine("Deciding to buy a game based on Price................");
            IsDeserveToBuy isDeserveToBuyBasedOnPrice = new IsDeserveToBuy(BuyBasedOnPrice);
            customer.BuyGames(vintageGamesLtd.Games, isDeserveToBuyBasedOnPrice);
        }
    }
}
