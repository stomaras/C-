using DesignPatterns.DAL;
using DesignPatterns.EshopStrategy;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MainContext
{
    public class EShopContext : DataAccessLayer
    {
        public IVariationStrategy variationStrategy;


        public EShopContext(IVariationStrategy strategy)
        {
            variationStrategy = strategy;
        }

        public int? CalculateSumTshirtCost(Tshirt tshirt)
        {

            // Go This to a method
            var sizePriceListStrategy = GetSizePriceList().ToList();
            SizeCostStrategy sizeCostStrategy = new SizeCostStrategy();
            int? costSize = sizeCostStrategy.Cost(tshirt);


            var colorRriceListStrategy = GetColorPriceList().ToList();
            ColorCostStrategy colorCostStrategy = new ColorCostStrategy();
            int? costColor = colorCostStrategy.Cost(tshirt);

            var fabricPriceListStrategy = GetFabricPriceList().ToList();
            FabricCostStrategy fabricCostStrategy = new FabricCostStrategy();
            int? costFabric = fabricCostStrategy.Cost(tshirt);

            int? TotalCost = costFabric + costSize + costColor;

            return TotalCost;

            
        }


        /// <summary>
        /// Return Price List of Based On Size
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SizePriceList> GetSizePriceList()
        {
            DataAccessLayer dal = new DataAccessLayer();
            return dal.unitOfWork.SizePriceList.GetAll();
        }

        /// <summary>
        /// Return Price List Based On Color
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ColorPriceList> GetColorPriceList()
        {
            DataAccessLayer dal = new DataAccessLayer();
            return dal.unitOfWork.ColorPriceList.GetAll();
        }


        public IEnumerable<FabricPriceList> GetFabricPriceList()
        {
            DataAccessLayer dal = new DataAccessLayer();
            return dal.unitOfWork.FabricPriceList.GetAll();
        }
    }
}
