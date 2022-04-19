using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1
{
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
                    new PcGame()
                    {
                        ID = 1,
                        Title = "Pac-Man",
                        Price = 5.00M,
                        Rating = 3,
                        ReleaseDate = new DateTime(1980, 6, 30)
                    },
                    new ConsoleGame()
                    {
                        ID = 2,
                        Title = "Tomb Raider 2",
                        Price = 7.00M,
                        Rating = 2,
                        ReleaseDate = new DateTime(1997,6,30)
                    },
                    new ConsoleGame()
                    {
                        ID = 3,
                        Title = "Tomb Raider 3",
                        Price = 8.00M,
                        Rating = 4,
                        ReleaseDate = new DateTime(1998,6,30)
                    }
                }
            };

            Console.WriteLine("Getting all games of Vintage Games Ltd");
            foreach(Game game in vintageGamesLtd.Games)
            {
                Console.WriteLine(game.Title);
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Sell all games of {vintageGamesLtd.Name}");
            foreach(Game game in vintageGamesLtd.Games)
            {
                game.Sell();
            }

            Shop spaceSystems = new Shop()
            {
                ID = 2,
                Name = "Space Systems Ltd",
                Games = new List<Game>()
                {
                    new PcGame()
                    {
                        ID = 4,
                        Title = "Dead Rising 4",
                        Price = 30.00M,
                        Rating = 2,
                        ReleaseDate = new DateTime(2016, 6, 30)
                    },
                    new ConsoleGame()
                    {
                        ID = 5,
                        Title = "Crash Bandicoot 3 Remake",
                        Price = 35.00M,
                        Rating = 2,
                        ReleaseDate = new DateTime(2017,6,30)
                    },
                    new ConsoleGame()
                    {
                        ID = 6,
                        Title = "Spyro the Dragon 2",
                        Price = 9.00M,
                        Rating = 3,
                        ReleaseDate = new DateTime(1999,6,30)
                    }
                }
            };

            List<Shop> shops = new List<Shop>() { vintageGamesLtd, spaceSystems };
            Console.WriteLine("Getting all data:");
            foreach(Shop shop in shops)
            {
                Console.WriteLine(shop.Name);
                Console.WriteLine($"Cheapest game is: {shop.CheapestGame.Title}");
                foreach(Game game in shop.Games)
                {
                    Console.WriteLine($"\t {game.Title}");
                }
            }

            Console.WriteLine("Getting the average of game ratings in each Loop");
            foreach(Shop shop in shops)
            {
                Console.WriteLine(shop.Name);
                Console.WriteLine($"\t Average rating: {shop.AverageRating}");
            }

            Console.WriteLine("Getting the newest game of each shop");
            foreach(Shop shop in shops)
            {
                Console.WriteLine(shop.Name);
                Console.WriteLine($"\t And the newest game is {shop.NewestGame.Title}");
            }

            Console.WriteLine("Deciding to buy a game");
            Customer customer = new Customer()
            {
                ID = 3,
                FullName = "Spyros Tom"
            };

            customer.BuyGames(vintageGamesLtd.Games);
        }
    }
}
