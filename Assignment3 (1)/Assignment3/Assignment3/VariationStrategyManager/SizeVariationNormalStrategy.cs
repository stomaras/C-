using Assignment3.Enums;
using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.VariationStrategyManager
{
    public class SizeVariationNormalStrategy : IVariationStrategy
    {//Timokatalogos

        private static Dictionary<Size, decimal> colorPricelist;

        static SizeVariationNormalStrategy()
        {
            colorPricelist = new Dictionary<Size, decimal>()
            {
                {Size.XS, 1m },
                {Size.S, 2m },
                {Size.M, 5m },
                {Size.L, 10m },
                {Size.Xl, 18m },
                {Size.XXL, 20m },
                {Size.XXXL, 50m }

            };
        }

        public void Cost(TShirt tshirt)
        {
            tshirt.Price += colorPricelist[tshirt.Size];
        }
    }
}
