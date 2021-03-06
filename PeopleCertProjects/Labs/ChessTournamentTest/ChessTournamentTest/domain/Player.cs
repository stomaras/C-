using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournamentTest.domain
{
    
    abstract class Player
    {
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

        public Player() { }

        public Player(int id, string name, int ranking)
        {
            Id = id;
            Name = name;
            Ranking = ranking;
        }

        public abstract override string ToString();
        //{
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Player { ").Append("Name: ").Append(Name).Append(", Ranking: ").Append(Ranking).Append(", Id: ").Append(Id).Append(" }");
            //return sb.ToString();
        //}

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
