using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournamentTesting.services
{
    interface IPlayerService
    {
        void Initialize();
        void Initialize(int[] idDetails, int[] nameDetails, int[] rankingDetails, int numOfPlayers);
    }
}
