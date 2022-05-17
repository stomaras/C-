using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateIndustry.Interfaces;
using ChocolateIndustry.Services;

namespace ChocolateIndustry.Models
{
    class WhiteChocolate : IChocolate
    {
        public string Name { get; } = "White";
        public int SellingPrice { get; set; }
        public int QualityIndex { get; set; }
     

        public WhiteChocolate()
        {
            SellingPrice = RandomService.Price();
            QualityIndex = RandomService.RandQualityIndex();
        }

        public override string ToString()
        {
            return $"WhiteChocolate {{Name : {Name}, SellingPrice : {SellingPrice}, QualityIndex {QualityIndex}}}";
        }

        
    }
}
