using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EshopStrategy
{
    public class FabricCostStrategy : IVariationStrategy
    {

        public FabricCostStrategy()
        {

        }

        /// <summary>
        /// Get Tshirt start price and returns price * 3
        /// </summary>
        /// <param name="tshirt"></param>
        /// <returns></returns>
        public int? Cost(Tshirt tshirt)
        {
            return tshirt.Price * 3;
        }
    }
}
