using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessTournamentTesting.domain;

namespace ChessTournamentTesting.services
{
    class Tournament
    {
        public void Start() {
            Console.WriteLine("Tournament Start");

            int[] idDetails = new int[2];
            idDetails[0] = 1;
            idDetails[1] = 501;

            int[] nameDetails = new int[1];
            nameDetails[0] = 3;

            int[] rankingDetails = new int[2];
            rankingDetails[0] = 1000;
            rankingDetails[1] = 3001;

            //PlayerService playerService = new PlayerService();
            PlayerService playerService = new PlayerService(idDetails, nameDetails, rankingDetails, 3);

            foreach(RandomPlayer player in playerService.Players)
            {
                Console.WriteLine(player);
            }

        }
    }
}
    


