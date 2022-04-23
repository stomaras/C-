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
 * Random Player Generate only one random player, i want a service to generate as many players i want each time
 * Random Player can generate only one player
 * 
 * PlayerService with the contract of IPlayerService will create as many players we want each time with different characteristics of rankings, ids, names
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
 * NOTE!!! Interface -> I + Class Name, is the way of communication among 2 things (like a contract). lock behaviours
 * NOTE!!! No body, no constructors in interfaces
 * NOTE!!! Tournament must say, you doing players, you doing games, you start the game
 * NOTE!!! The result of GeneratePlayers() of IPlayerService interface, which will implemented in the PlayerService class, will fill the list of Tournament Class which in the end must have the players
 * NOTE!!! When the Constructor of PlayerService play then we will do the implementation of all the methods we want
 * NOTE!!! void Initialize() method in the IPlayerService Interface , which implemented in the PlayerService Class , calls the default constructor of RandomPlayer Class.
 * NOTE!!! void Initialize(int[] idDetails, int[] nameDetails, int[] rankingDetails) method in the IPlayerService Interface, which implemented in the PlayerService Class , calls overloaded constructor of RandomPlayer Class.
 * NOTE!!! List<RandomPlayer> GeneratePlayers(int numOfPlayers) method in the IPlayerService Interface, which implemented in the PlayerService class, create players take into consideration players from default initialize or
 *         overloaded initialize().
 * NOTE!!! I match all defaults of RandomPlayer with all defaults of PlayerService
 * NOTE!!! I match all overloaded of RandomPlayer with all overloaded of PlayerService
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
