using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCB16
{
    class Software : Product // Software is a Product. This is an IS-A Relationship
    {
        public int ISBN { get; set; }

        // override means i make my own version of Sale Method
        public override void Sale()
        {
            base.Sale();
            Console.WriteLine($" ISBN is {ISBN}");
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
