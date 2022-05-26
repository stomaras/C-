using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApplicationConsole
{
    class Program
    {
        /*
         * Movie Management System
         * Genre - Movie : Many to Many Relationship
         * Movie - Actor : Many to Many Relationship
         * Movie - Director : Many to One Relationship
         * Movie can be From One Country
         * Actor can be From One Country
         * Director can be From One Country
         * 
         * A-Create Synthetic data:
         * - At least 10 Movies
         * - At least 20 Actors
         * - At least 5 directors
         * - At least 5 genres
         * - Relate Every Entity
         * 
         * B-Display All Data
         * - Show all Movies.
         * - Show all Actors.
         * - Show all Directors.
         * - Show all Countries.
         * - Show all Movies per Director.
         * - Show all Directors per Movie.
         * - Show Movies Per Director
         * - Show Actor per Country
         * 
         * C- Display Data Ordered by Ascending
         * - Show all movies ordered by title
         * - Show all movies by Rating
         * - Show all movies by price
         * - Show all actors by First Name
         * - Show all actors by Last Name
         * - Show all actors by salary
         * - Show all actors by year of birth
         * - Show all directors by first name
         * - Show all directors by last name
         * - Show all directors by age
         * - Show all directors by year of birth
         * 
         * D-Display Data Filter By
         * - Show all Movies filtered by searching Title.
         * - Show all Actors filtered by searching FirstName or LastName.
         * - Show all Directors by searching FirstName or LastName.
         * 
         * E-Display STATS
         * - Show number of Movies.
         * - Show number of Actors.
         * - Show number of Directors.
         * - Show number of Actors grouped by Country.
         * 
         */
        static void Main(string[] args)
        {
            MyDatabase db = new MyDatabase();

            const int first = -40;
            const int second = -50;
            const int third = -50;
            const int fourth = -40;
            string input;

            do
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Choose an option");
                Console.WriteLine();
                Console.ResetColor();

                Console.WriteLine($"{"------------ ALL DATA ----------------",first}{"--------------ORDERED BY-------------------",second}{"-------------------FILTER BY-------------------",third}{"----------------STATS------------------",fourth}{"----------------E - EXIT----------------"}");
                Console.WriteLine($"{"1 - Movies",first}{"10 - Movies By Title",second}{"21 - Movies By Title",third}{"24 - Movies Count",fourth}");
                Console.WriteLine($"{"2 - Actors",first}{"11 - Movies By Rating",second}{"22 - Actors By FirstName or LastName",third}{"25 - Actors Count",fourth}");
                Console.WriteLine($"{"3 - Directors",first}{"12 - Movies By Price",second}{"23 - Directors By FirstName or LastName",third}{"26 - Directors Count",fourth}");
                Console.WriteLine($"{"4 - Countries",first}{"13 - Actors By FirstName",second}{"",third}{"27 - Actors By Country",fourth}");
                Console.WriteLine($"{"5 - Movies Per Director",first}{"14 - Actors By LastName",second}");
                Console.WriteLine($"{"6 - Directors Per Movie",first}{"15 - Actors By Salary",second}");
                Console.WriteLine($"{"7 - Movies Per Actor",first}{"16 - Actors By year of Birth",second}");
                Console.WriteLine($"{"8 - Actors Per Movie",first}{"17 - Directors By FirstName",second}");
                Console.WriteLine($"{"9 - Actors Per Country",first}{"18 - Directors By LastName",second}");

                input = Console.ReadLine();
                switch (input)
                {
                    case "1": View.Movies(db.Movies,"All Movies"); break;
                    case "2": View.Actors(db.Actors,"All Actors"); break;
                    case "3": View.Directors(db.Directors, "All Directors");break;
                    case "4": View.Countries("All Countries");break;
                    case "5": View.MoviesPerDirector(db.Directors, "All Movies Per Director");break;
                    case "6": View.DirectorsPerMovie(db.Movies, "All Directors Per Movie"); break;
                    case "7": View.MoviesPerActor(db.Actors, "All Movies Per Actor");break;
                    case "8": View.ActorsPerMovie(db.Movies, "All Actors Per Movie");break;
                    case "9": View.ActorsPerCountry(db.Actors, "Actors Per Country"); break;
                    default:
                        Console.WriteLine("Wrong choice try again!"); break;
                }

            } while (input != "E" && input != "e");
        }
    }

    public class View
    {
        public static void Movies(List<Movie> movies, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-5}{"Title",-25}{"Country",-15}{"Rating",-10}{"Year",-10}{"Duration",-10}{"Price",-10}");
            Console.ResetColor();
            foreach (var movie in movies)
            {
                movie.Print();
            }
        }

        public static void Actors(List<Actor> actors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-5}{"FirstName",-25}{"LastName",-15}{"DateOfBirth",-15}{"Salary",-15}{"Age",-20}{"DateOfDeath",-10}");
            foreach (var actor in actors)
            {
                actor.Print();
            }
        }

        public static void Directors(List<Director> directors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-5}{"FirstName",-15}{"LastName",-15}{"Country",-10}{"Birth",-10}{"Death",-10}{"Age",-10}");
            foreach (var director in directors)
            {
                director.Print();
            }
        }

        public static void Countries(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-5}{"Country",-25}");
            Console.ResetColor();
            string[] names = Enum.GetNames(typeof(Country));
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i,-5}{names[i],-25}");
            }
        }

        public static void MoviesPerDirector(List<Director> directors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"FirstName",-15}{"LastName",-15}{"Movies",-25}");
            Console.ResetColor();
            foreach (var director in directors)
            {
                director.PrintName();
                foreach (var movie in director.Movies)
                {
                    Console.Write($"{" ",-30}");
                    movie.PrintTitle();
                }
            }
        }

        public static void DirectorsPerMovie(List<Movie> movies, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Movies",-25}{"FirstName",-15}{"LastName",-15}");
            Console.ResetColor();
            foreach (var movie in movies)
            {
                movie.PrintTitle();
                Console.Write($"{"",-25}");
                movie.Director.PrintName();
            }
        }

        public static void MoviesPerActor(List<Actor> actors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"FirstName",-15}{"LastName",-15}{"Movies",-15}");
            Console.ResetColor();
            foreach (var actor in actors)
            {
                actor.PrintName();
                foreach (var movie in actor.Movies)
                {
                    Console.Write($"{"",-30}");
                    movie.PrintTitle();
                }
            }
        }

        public static void ActorsPerMovie(List<Movie> movies, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Movies",-25}{"FirstName",-15}{"LastName",-15}");
            Console.ResetColor();
            foreach (var movie in movies)
            {
                movie.PrintTitle();
                foreach (var actor in movie.Actors)
                {
                    Console.Write($"{"",-25}");
                    actor.PrintName();
                }
            }
        }

        public static void ActorsPerCountry(List<Actor> actors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"FirstName",-15}{"LastName",-15}{"Country",-25}");
            Console.ResetColor();
            foreach (var actor in actors)
            {
                actor.PrintNameAndCountry();
            }
        }
    }
        

}
