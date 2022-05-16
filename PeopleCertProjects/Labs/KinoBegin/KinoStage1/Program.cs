using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoStage1.Domain;
namespace KinoStage1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kino kino = new Kino();
            // Games, Players, KinoBonus
            //kino.Start(1, 10, true);
            kino.Start(10,true,5);

        }
    }
}
