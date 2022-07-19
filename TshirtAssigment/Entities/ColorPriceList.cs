using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ColorPriceList
    {
        public int Id { get; set; }
        public Enum Color { get; set; }
        public int Price { get; set; }

    }
}
