using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoBegin.Services;

namespace KinoBegin.Domains
{
    class Lottery
    {

        private int _LID;

        public int LID
        {
            get { return _LID; }
            set { _LID = value; }
        }


        private List<int> _lotteryNumbers;

        public List<int> LotteryNumbers
        {
            get { return _lotteryNumbers; }
            set { _lotteryNumbers = value; }
        }

        private bool _kinoBonus;

        public bool KinoBonus
        {
            get { return _kinoBonus; }
            set { _kinoBonus = value; }
        }


        public Lottery(bool KinoPlayerBonus)
        {
            LotteryNumbers = new List<int>();
            LotteryService lotteryService = new LotteryService();
            LotteryNumbers = lotteryService.AddKinoNumbers(LotteryNumbers);
            KinoBonus = KinoPlayerBonus;
            LID++;
        }

        public override string ToString()
        {
            string s = $"Lottery {LID} {{ \n";
            for(int i=0; i<= LotteryNumbers.Count-1; i++)
            {
                if(i == LotteryNumbers.Count - 1 && KinoBonus)
                {
                    s = s + $"bonus number {i + 1} -> {LotteryNumbers[i]}" + "\n";
                }
                else
                {
                    s = s + $"lottery number {i + 1} -> {LotteryNumbers[i]}" + "\n";
                }
               

            }
            s = s + $"}}";
            return s;
        }

    }
}
