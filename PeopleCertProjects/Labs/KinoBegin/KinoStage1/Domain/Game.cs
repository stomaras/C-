using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoStage1.Domain
{
    class Game
    {

        private static int _GID;

        public static int GID
        {
            get { return _GID; }
            set { _GID = value; }
        }

        private List<Player> _players;

        public List<Player> Players
        {
            get { return _players; }
            set { _players = value; }
        }

        private Lottery _lottery;

        public Lottery Lottery
        {
            get { return _lottery; }
            set { _lottery = value; }
        }


        public Game()
        {
            
        }

        public int GenerateGameID()
        {
            GID++;
            return GID;
        }

    }
}
