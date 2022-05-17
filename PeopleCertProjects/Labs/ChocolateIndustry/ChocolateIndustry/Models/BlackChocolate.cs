using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateIndustry.Interfaces;
using ChocolateIndustry.Services;

namespace ChocolateIndustry.Models
{
    class BlackChocolate : IChocolate
    {
        public string Name { get; } = "Black";
        public int SellingPrice { get; set; }
        public int QualityIndex { get; set; }
        public int NumberOfChocolates { get; private set; }

        public BlackChocolate()
        {
            SellingPrice = RandomService.Price();
            QualityIndex = RandomService.RandQualityIndex();
        }

        public override string ToString()
        {
            return $"BlackChocolate {{Name: {Name}, Selling Price: {SellingPrice}, Quality Index: {QualityIndex}}}";
        }

        
    }
}
