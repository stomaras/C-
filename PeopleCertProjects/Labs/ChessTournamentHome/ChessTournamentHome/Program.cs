using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessTournamentHome.services;
using ChessTournamentHome.domain;


/*
 * For each Player
 * I have one random id (1-201), one random string (ranking), one random ranking (1000-2000)
 * 
 * random id -> 1-200 : public static int CreateRandomNumber(int min, int max)
 * random string (nickname) -> 4 characters : public static string CreateRandomName()
 * random ranking -> 1000-2000 : public static int CreateRandomNumber(int min, int max)
 * Creation of random player will go inside services.
 * I don't want creation Of Player Objects directly from main, I want in main -> return RandomPlayer()
 * From service i want to generate a random Player
 * 
 * A Random Player based on a service , in order to generate ID, Name, Ranking
 * Interface will lock behaviour of RandomPlayer with the help of a Service
 * 
 */

/*
 * NOTE!!! strings is immutable
 * NOTE!!! StringBuilder has 20 # ways to make Append, 20 different constructors overloaded
 * NOTE!!! Every character has an arithmetic representation in a table from characters (UTF)
 *         in any position of the table there is a represenatation of only one character
 *         65 -> A
 *         66 -> B
 * NOTE!!! I don't want someone to create Players hands on, I want to create Players Directly with the help of service (randomly)
 * NOTE!!! In Abstract classes and Interfaces i can't instantiate Objects, I want this class to be generic type, I don't want class Player instantiate Objects hands on
 * NOTE!!! In Abstarct class i can have whatever i want , methods, properties e.t.c
 * NOTE!!! In Abstract classes , all abstract methods must implemented from child classes, all abstarct methods can't have body.
 * 
 */


namespace ChessTournamentHome
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessTournament tournament = new ChessTournament();
            tournament.start();
            Player p1 = CreateRandomPlayer();
            Console.WriteLine(p1);
            
        }

        public static Player CreateRandomPlayer()
        {
            return new RandomPlayer();
        }

        
    }
}
