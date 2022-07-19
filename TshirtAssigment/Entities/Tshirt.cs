using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tshirt : PriceList
    {
        [Key]
        public int Id { get; set; }
        public Mark Mark { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Fabric Fabric { get; set; }
        public int? Price { get; set; }

    }
}
