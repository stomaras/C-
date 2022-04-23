using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessTournamentTest.domain;
using ChessTournamentTest.services;

namespace ChessTournamentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = CreateRandomPlayer();
            Console.WriteLine(player);



        }

        public static Player CreateRandomPlayer()
        {
            return new RandomPlayer();
        }
    }
}
