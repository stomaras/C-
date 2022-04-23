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
        public PlayerService()
        {
            _numOfPlayers = 10;
        }
        public List<Player> GeneratePlayers(int numOfPlayers)
        {
            numOfPlayers = numOfPlayers;
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void Initialize(int[] idDetails, int[] nameDetails, int[] rankingDetails)
        {
            throw new NotImplementedException();
        }
    }
}
