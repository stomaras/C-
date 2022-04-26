using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessTournamentTesting.domain;
using ChessTournamentTesting.services;

namespace ChessTournamentTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Tournament tournament = new Tournament();
            tournament.Start();
           
        }
    }
}
