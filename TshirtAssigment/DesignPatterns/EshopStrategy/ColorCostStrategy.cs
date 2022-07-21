using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EshopStrategy
{
    public class ColorCostStrategy : IVariationStrategy
    {

        public ColorCostStrategy()
        {

        }


        /// <summary>
        /// Take a tshirt and increase price actual price * 2;
        /// </summary>
        /// <param name="tshirt"></param>
        /// <returns></returns>
        public int? Cost(Tshirt tshirt)
        {
            var cost = tshirt.Price * 2;
            return cost;
        }
    }
}
