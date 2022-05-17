using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateIndustry.Interfaces;
using ChocolateIndustry.Services;

namespace ChocolateIndustry.Models
{
    class MilkChocolate : IChocolate
    {
        public string Name { get; } = "Milk";
        public int SellingPrice { get; set; }
        public int QualityIndex { get; set; }
     

        public MilkChocolate()
        {
            SellingPrice = RandomService.Price();
            QualityIndex = RandomService.RandQualityIndex();
        }

        public override string ToString()
        {
            return $"MilkChocolate {{Name : {Name}, SellingPrice : {SellingPrice}, QualityIndex {QualityIndex}}}";
        }

       
    }
}
