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


        public int Cost(Tshirt tshirt)
        {
            throw new NotImplementedException();
        }
    }
}
