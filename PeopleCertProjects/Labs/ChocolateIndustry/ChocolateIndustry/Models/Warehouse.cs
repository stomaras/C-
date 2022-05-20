using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateIndustry.Models
{
    class Warehouse
    {
        public int CurrentLoad { get; set; }
        public int MaxLoad { get; private set; } = 1000;
        public int Reserve { get; set; }

        public int NumberOfBlackChocolates { get; private set; } = 10000;
        public int NumberOfWhiteChocolates { get; private set; } = 8000;
        public int NumberOfMilkChocolates { get; set; } = 8000;

        public Warehouse()
        {

        }
    }
}
