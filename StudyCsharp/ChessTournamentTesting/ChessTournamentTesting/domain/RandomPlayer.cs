using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournamentTesting.domain
{
    class RandomPlayer : Player
    {
        private int[] _idDetails;
        private int[] _nameDetails;
        private int[] _rankingDetails;

        public static Random random;
        public RandomPlayer(int[] idDetails, int[] nameDetails, int[] rankingDetails)
        {
            _idDetails = idDetails;
            _nameDetails = nameDetails;
            _rankingDetails = rankingDetails;
            this.Id = CreateRandomNumber(_idDetails[0], _idDetails[1]);
            this.Name = CreateRandomName(_nameDetails[0]);
            this.Ranking = CreateRandomNumber(_rankingDetails[0], _rankingDetails[1]);

        }
        public RandomPlayer()
        {
            _idDetails = new int[2];
            _nameDetails = new int[1];
            _rankingDetails = new int[2];

            _idDetails[0] = 1;
            _idDetails[1] = 201;
            this.Id = CreateRandomNumber(_idDetails[0], _idDetails[1]);

            _nameDetails[0] = 3;
            this.Name = CreateRandomName(_nameDetails[0]);

            _rankingDetails[0] = 1000;
            _rankingDetails[1] = 2001;
            this.Ranking = CreateRandomNumber(_rankingDetails[0], _rankingDetails[1]);

        }

        private int CreateRandomNumber(int min, int max)
        {
            random = new Random();
            int result = random.Next(min, max);
            return result;
        }

        private string CreateRandomName(int numOfChars)
        {
            char ch;
            string name = "";
            Random rand = new Random();
            for (int i=0; i<=numOfChars; i++)
            {
                
                int result = rand.Next(65, 91);
                ch = (char)result;
                name += ch;
            }
            return name;
        }

        public override string ToString()
        {
            return $"Player: with name {this.Name}, with ranking {this.Ranking}, with id {this.Id}";
        }
    }
}
