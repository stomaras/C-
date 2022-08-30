using Assignment3.Enums;
using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.VariationStrategyManager
{
    public class ColorVariationNormalStrategy : IVariationStrategy
    {
        //Timokatalogos

        private static Dictionary<Color, decimal> colorPricelist;

        static ColorVariationNormalStrategy()
        {
            colorPricelist = new Dictionary<Color, decimal>()
            { 
                {Color.Blue, 1m },
                {Color.Green, 2m },
                {Color.Indigo, 22m },
                {Color.Orange, 6m },
                {Color.Red, 8m },
                {Color.Violet, 12m },
                {Color.Yellow, 20m }

            };
        }

        public void Cost(TShirt tshirt)
        {
            tshirt.Price += colorPricelist[tshirt.Color];
        }
    }
}
