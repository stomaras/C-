using DesignPatterns.DAL;
using Entities;
using Entities.Enums;
using Repositories.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EshopStrategy
{
    public class SizeCostStrategy : IVariationStrategy
    {
        private static Dictionary<Size, int> sizePriceList;

        public SizeCostStrategy()
        {

           
        }


        /// <summary>
        /// Get tshirt cost and return cost * 3(euro or $)
        /// </summary>
        /// <param name="tshirt"></param>
        /// <returns></returns>
        public int? Cost(Tshirt tshirt)
        {
            int? cost = tshirt.Price * 3;
            return cost;
        }
    }
}
