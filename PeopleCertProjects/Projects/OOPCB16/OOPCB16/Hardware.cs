using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCB16
{
    class Hardware : Product
    {

        public int SerialNumber { get; set; }

        public override void Sale()
        {
            Console.WriteLine($"My Serial Number is {SerialNumber}");
        }
    }
}
