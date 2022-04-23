using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournamentHome.domain
{
    class RandomPlayer : Player
    {

        private int[] _idDetails;
        private int[] _rankingDetails;
        private int[] _nameDetails;

        public RandomPlayer()
        {
            _idDetails = new int[2];
            _idDetails[0] = 1;
            _idDetails[1] = 201; 
            this.Id = CreateRandomNumber(_idDetails[0], _idDetails[1]);


            _nameDetails = new int[3];
            _nameDetails[0] = 65;
            _nameDetails[1] = 91;
            _nameDetails[2] = 3;
            this.Name = CreateRandomName(_nameDetails[0], _nameDetails[1], _nameDetails[2]);

            _rankingDetails = new int[2];
            _rankingDetails[0] = 1000;
            _rankingDetails[1] = 2001;
            this.Ranking = CreateRandomNumber(_rankingDetails[0], _rankingDetails[1]);
        }

        public RandomPlayer(int[] idDetails, int[] nameDetails, int[] rankingDetails)
        {
            _idDetails = idDetails;
            _nameDetails = nameDetails;
            _rankingDetails = rankingDetails;
            this.Id = CreateRandomNumber(_idDetails[0], _idDetails[1]);
            this.Name = CreateRandomName(_nameDetails[0], _nameDetails[1], _nameDetails[2]);
            this.Ranking = CreateRandomNumber(_rankingDetails[0], _rankingDetails[1]);
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
