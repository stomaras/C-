using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1
{
    class PcGame : Game
    {
        public override void Sell()
        {
            Console.WriteLine($"The PC Game with title: {Title} has been sold");
        }
    }
}
