using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament
{
    class Player
    {
        // Id, Name, Ranking
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _ranking;

        public int Ranking
        {
            get { return _ranking; }
            set { _ranking = value; }
        }


    }
}
