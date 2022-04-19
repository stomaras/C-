using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam
{
    class PlayerNotAddedException : Exception
    {
        public PlayerNotAddedException() { }

        public PlayerNotAddedException(string name): base(String.Format("Player with name: {0} already exists!", name))
        {

        }
    }
}
