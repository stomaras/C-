using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoBegin.Domains;
using KinoBegin.Services;

namespace KinoBegin
{
    class Kino
    {

        

        public Kino() { }

        public void Start()
        {
            Ticket ticket = new Ticket();
            Player player = new Player(ticket);
            Console.WriteLine(player.ToString());
            Lottery lottery = new Lottery(player.KinoBonus);
            Console.WriteLine(lottery.ToString());
            List<int> LotteryNums = lottery.LotteryNumbers;
            List<int> Ticketnums = ticket.Numbers;
            bool KinoBonus = player.KinoBonus;
            if (KinoBonus)
            {
                EvaluationService evaluationService = new EvaluationService(LotteryNums, Ticketnums, KinoBonus);
                int num = evaluationService.CountOfWinNumbers;
                bool kinoBonus = evaluationService.KinoBonus;
                if (kinoBonus)
                {
                    PrintService.PlayerWinsKinoBonus();
                    evaluationService.PrintWinNumbers(num);
                }
                else
                {
                    PrintService.PlayerLostKinoBonus();
                    evaluationService.PrintWinNumbers(num);
                }
                
            }
            else
            {
                EvaluationService evaluationService = new EvaluationService(LotteryNums, Ticketnums);
                int num = evaluationService.CountOfWinNumbers;
                evaluationService.PrintWinNumbers(num);
            }
            
            
           
            
           
            
            
        }
    }
}
