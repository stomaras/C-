using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournamentTesting.domain
{
    abstract class Player
    {
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private int _Ranking;

        public int Ranking
        {
            get { return _Ranking; }
            set { _Ranking = value; }
        }

        public Player() { }

        public Player(int id, string name, int ranking)
        {
            this.Id = id;
            this.Name = name;
            this.Ranking = ranking;
        }

        public abstract override string ToString();

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
