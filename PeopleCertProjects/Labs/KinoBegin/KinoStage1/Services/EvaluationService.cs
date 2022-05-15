using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoStage1.Domain;

namespace KinoStage1.Services
{
    class EvaluationService
    {
        private Player _players;

        public Player Player
        {
            get { return _players; }
            set { _players = value; }
        }

        private Ticket _ticket;

        public Ticket Ticket
        {
            get { return _ticket; }
            set { _ticket = value; }
        }

        private bool _CatchKinoBonus;

        public bool CatchKinoBonusNumber
        {
            get { return _CatchKinoBonus; }
            set { _CatchKinoBonus = value; }
        }



        private int _count;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public EvaluationService(Player player, Lottery lottery, bool kinoBonus) 
        {
            Count = CatchNumbers(player, lottery);
            CatchKinoBonusNumber = CatchKinoBonus(player, lottery, kinoBonus);
        }

        public EvaluationService(Player player, Lottery lottery)
        {
            Count = CatchNumbers(player, lottery);
        }

        private int CatchNumbers(Player player, Lottery lottery)
        {
            List<int> UserNumbers = player.Ticket.Numbers;
            List<int> LotteryNumbers = lottery.LotteryNumbers;
            int count = 0;
            for(int i=0; i<= LotteryNumbers.Count-1; i++)
            {
                for(int j=0; j<= UserNumbers.Count-1; j++)
                {
                    if (LotteryNumbers[i] == UserNumbers[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private bool CatchKinoBonus(Player player, Lottery lottery, bool PlayWithKinoBonus)
        {
            if (!PlayWithKinoBonus)
            {
                return false;
            }
            else
            {
                List<int> UserNumbers = player.Ticket.Numbers;
                List<int> LotteryNumbers = lottery.LotteryNumbers;
                
                for (int j = 0; j <= UserNumbers.Count - 1; j++)
                {
                    if (LotteryNumbers[LotteryNumbers.Count - 1] == UserNumbers[j])
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }

    }
}
