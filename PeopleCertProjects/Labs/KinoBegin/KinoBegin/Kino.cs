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

        public Kino()
        {

        }

        // stage 1
        //public void Start()
        //{
        //    Ticket ticket = new Ticket();
        //    Player player = new Player(ticket);
        //    Console.WriteLine(player);
        //    Lottery lottery = new Lottery(player.KinoBonus);
        //    Console.WriteLine(lottery.ToString());
        //    List<int> UserNumbers = player.Ticket.Numbers;
        //    List<int> KinoNumbers = lottery.LotteryNumbers;
        //    EvaluationService evaluationService = new EvaluationService(UserNumbers, KinoNumbers);
        //    evaluationService.CheckMatches(UserNumbers, KinoNumbers, player.KinoBonus);
        //}

        // stage 2
        public void Begin()
        {
            Ticket ticket = new Ticket();
            Console.WriteLine(ticket);

            
            
           
        }

        
    }
}
