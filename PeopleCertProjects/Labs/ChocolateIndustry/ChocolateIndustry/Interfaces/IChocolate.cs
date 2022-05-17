using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateIndustry.Interfaces
{
    public interface IChocolate
    {
        string Name { get; }
        int SellingPrice { get; set; }
        int QualityIndex { get; set; }


        
        
    }
}
