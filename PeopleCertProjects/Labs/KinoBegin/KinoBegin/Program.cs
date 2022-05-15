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
            Kino kino = new Kino();

            // stage 1
            //kino.Start();

            // stage 2
            kino.Begin();
        }
    }
}
