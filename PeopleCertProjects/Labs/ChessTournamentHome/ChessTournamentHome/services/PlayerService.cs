using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessTournamentHome.domain;


namespace ChessTournamentHome.services
{
    class PlayerService : IPlayerService
    {

        private int _numOfPlayers;
        private int[] _idDetails;
        private int[] _nameDetails;
        private int[] _rankingDetails;

        public List<Player> Players { get; private set; }
        public PlayerService()
        {
            Initialize();   
            Players = GeneratePlayers();
        }


        public PlayerService(int[] idDetails, int[] nameDetails, int[] rankingDetails, int numOfPlayers)
        {
            _numOfPlayers = numOfPlayers;
            Initialize(idDetails, nameDetails, rankingDetails);
            Players = GeneratePlayers();
        }
       
        private List<Player> GeneratePlayers()
        {
            List<Player> players = new List<Player>();
            for(int i=0; i<_numOfPlayers; i++)
            {
                players.Add(new RandomPlayer(_idDetails, _nameDetails, _rankingDetails));
            }
            return players;
           
        }

        public void Initialize()
        {
            _numOfPlayers = 10;
        }

        public void Initialize(int[] idDetails, int[] nameDetails, int[] rankingDetails)
        {
            _idDetails = idDetails;
            _nameDetails = nameDetails;
            _rankingDetails = rankingDetails;
        }
    }
}
