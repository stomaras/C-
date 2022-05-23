using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoolateIndustryProduction.Interfaces
{
    public interface IChocolate
    {
        string Name { get; set; }
        int PricePerKg { get; set; }
        int QualityIndex { get; set; }
        int Quantity { get; set; }
    }
}
