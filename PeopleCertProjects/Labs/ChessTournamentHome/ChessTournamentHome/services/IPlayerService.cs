using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessTournamentHome.domain;

namespace ChessTournamentHome.services
{
    interface IPlayerService
    {
        void Initialize();
        void Initialize(int[] idDetails, int[] nameDetails, int[] rankingDetails);
        List<Player> GeneratePlayers(int numOfPlayers);
    }
}
