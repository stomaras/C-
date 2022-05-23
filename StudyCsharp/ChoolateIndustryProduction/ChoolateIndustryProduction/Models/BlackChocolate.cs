using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoolateIndustryProduction.Interfaces;

namespace ChoolateIndustryProduction.Models
{
    class BlackChocolate : IChocolate
    {
        public string Name { get ; set ; }
        public int PricePerKg { get ; set ; }
        public int QualityIndex { get ; set ; }
        public int Quantity { get; set; }
    }
}
