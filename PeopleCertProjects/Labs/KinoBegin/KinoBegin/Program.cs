using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoBegin.Domains;
namespace KinoBegin
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket();
            Player player = new Player(ticket);
            Console.WriteLine(player);
            Lottery lottery = new Lottery(player.KinoBonus);
            Console.WriteLine(lottery.ToString());
        }
    }
}
