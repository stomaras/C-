using Assignment3.Enums;
using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.VariationStrategyManager
{
    public class FabricVariationNormalStrategy : IVariationStrategy
    { //Timokatalogos

        private static Dictionary<Fabric, decimal> colorPricelist;

        static FabricVariationNormalStrategy()
        {
            colorPricelist = new Dictionary<Fabric, decimal>()
            {
                {Fabric.Rayon, 1m },
                {Fabric.Silk, 2m },
                {Fabric.Linen, 22m },
                {Fabric.Wool, 6m },
                {Fabric.Polyester, 8m },
                {Fabric.Cashmere, 12m },
                {Fabric.Cotton, 20m }

            };
        }

        public void Cost(TShirt tshirt)
        {
            tshirt.Price += colorPricelist[tshirt.Fabric];
        }
    }
}
