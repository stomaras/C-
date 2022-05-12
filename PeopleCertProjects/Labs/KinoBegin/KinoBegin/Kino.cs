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

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public Kino() { }

        public void Start()
        {
            Ticket ticket = new Ticket();
            Player player = new Player(ticket);
            Console.WriteLine(player);
            Lottery lottery = new Lottery(player.KinoBonus);
            Console.WriteLine(lottery.ToString());
            List<int> KinoNumbers = new List<int>();
            List<int> LotteryNumbers = new List<int>();
            LotteryNumbers = lottery.LotteryNumbers;
            KinoNumbers = ticket.Numbers;
        }
    }
}
