using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessTournamentTesting.domain;

namespace ChessTournamentTesting.services
{
    class PlayerService : IPlayerService
    {
        private int _numOfPlayers;
        private int[] IdDetails = new int[2];
        private int[] NameDetails = new int[1];
        private int[] RankingDetails = new int[2];

        public List<Player> Players { get; private set; }

        public PlayerService()
        {
            Initialize();
            Players = GeneratePlayers();
        }

        public PlayerService(int[] idDetails, int[] nameDetails, int[] rankingDetails, int numOfPlayers)
        {
       
            Initialize(IdDetails, NameDetails, RankingDetails, numOfPlayers);
            Players = GeneratePlayers();
        }

        public List<Player> GeneratePlayers()
        {
            List<Player> players = new List<Player>();
            for(int i=0; i<_numOfPlayers; i++)
            {
                RandomPlayer random = new RandomPlayer();
                //Console.WriteLine(random);
                players.Add(random);
                
            }
            return players;
        }
        public void Initialize()
        {
            _numOfPlayers = 10;
        }

        public void Initialize(int[] idDetails, int[] nameDetails, int[] rankingDetails, int numOfPlayers)
        {
            _numOfPlayers = numOfPlayers;
            IdDetails = idDetails;
            NameDetails = nameDetails;
            RankingDetails = rankingDetails;

        }
    }
}
