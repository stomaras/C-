using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournamentHome.domain
{
    class RandomPlayer : Player
    {

        public RandomPlayer()
        {
            this.Id = CreateRandomNumber(1, 201);
            this.Name = CreateRandomName(65, 91, 4);
            this.Ranking = CreateRandomNumber(1000, 2001);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Player { ").Append(" Name : ").Append(Name).Append(" Id : ").Append(Id).Append(" Ranking: ").Append(Ranking).Append(" }");
            return sb.ToString();
        }

        private int CreateRandomNumber(int min, int max)
        {
            int result = 0;
            Random rand = new Random();
            result = rand.Next(min, max);
            return result;
        }

        private string CreateRandomName(int min, int max, int numOfChars)
        {
            string result = "";
            StringBuilder sb = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i < numOfChars; i++)
            {
                sb.Append((char)rand.Next(min, max));
            }
            result = sb.ToString();
            return result;
        }
    }
}
