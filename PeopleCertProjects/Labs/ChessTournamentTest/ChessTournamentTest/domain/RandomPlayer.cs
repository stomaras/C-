using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournamentTest.domain
{
    class RandomPlayer : Player
    {
        public RandomPlayer() {
            this.Id = CreateRandomNumber(1, 201);
            this.Name = CreateRandomName(3);
            this.Ranking = CreateRandomNumber(1000, 2001);
        }
        private int CreateRandomNumber(int min, int max)
        {
            int result;
            Random rand = new Random();
            result = rand.Next(min, max);
            return result;
        }

        private string CreateRandomName(int numOfChars)
        {
            string result = "";
            char character;
            Random rand = new Random();
            for (int i=0; i<= numOfChars; i++)
            {
                character = (char)rand.Next(65, 91);
                result += character;
                
            }
            return result;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Player { ").Append("Name: ").Append(Name).Append(", Ranking: ").Append(Ranking).Append(", Id: ").Append(Id).Append(" }");
            return sb.ToString();
        }
    }

}
