using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FabricPriceList
    {
        public int Id { get; set; }
        public Fabric Fabric { get; set; }
        public int Price { get; set; }
    }
}
