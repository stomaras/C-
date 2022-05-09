using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject.Services
{
    class RandomService
    {

        private static Random _rand = new Random((int)DateTime.Now.Ticks);
        public static int Number(int min, int max)
        {
            int result = 0;
            result = _rand.Next(min, max);
            return (result);
        }
    }
}
