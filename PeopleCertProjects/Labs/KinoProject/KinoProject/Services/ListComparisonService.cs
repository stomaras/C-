using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject.Services
{


    class ListComparisonService
    {
        public List<int> UserNumbers { get; private set; }
        public List<int> KinoNumbers { get; private set; }

        private int _matches;

        public int Matches
        {
            get { return _matches; }
            set { _matches = value; }
        }


        public ListComparisonService(List<int> UserNumbers, List<int> KinoNumbers)
        {
            this.UserNumbers = UserNumbers;
            this.KinoNumbers = KinoNumbers;
        }

        public void CheckMatches(List<int> UserNumbers, List<int> KinoNumbers)
        {
            for(int i=0; i<= UserNumbers.Count-1; i++)
            {
                for(int j=0; j<= KinoNumbers.Count-1; j++)
                {
                    if(UserNumbers[i] == KinoNumbers[j])
                    {
                        Matches++;
                    }
                }
            }
            Console.WriteLine("User catch: " + Matches + " Numbers ");
        }
    }
}
