using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Furniture : File
    {
        // Factory Method Implementation
        public override void CreateItemss()
        {
            Itemss.Add(new SofasetItems());
        }
    }
}
