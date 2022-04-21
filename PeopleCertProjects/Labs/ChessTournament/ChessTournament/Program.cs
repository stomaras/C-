using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessTournament tournament = new ChessTournament();
            tournament.Start();

            Player p1 = CreateRandomPlayer(); // new Player(1, "Pasparov", 0);

        }

        public static Player CreateRandomPlayer()
        {
            return (new Player(1,"AAA", 1000));
        }
    }
}
