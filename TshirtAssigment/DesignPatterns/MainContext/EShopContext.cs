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
            int? costSize = CalculateSizeCostPrice(sizePriceListStrategy, sizeCostStrategy, tshirt);


            var colorRriceListStrategy = GetColorPriceList().ToList();
            ColorCostStrategy colorCostStrategy = new ColorCostStrategy();
            int? costColor = CalculateColorCostPrice(colorRriceListStrategy, colorCostStrategy, tshirt);

            var fabricPriceListStrategy = GetFabricPriceList().ToList();
            FabricCostStrategy fabricCostStrategy = new FabricCostStrategy();
            int? costFabric = CalculateFabricCostPrice(fabricPriceListStrategy, fabricCostStrategy, tshirt);

            int? TotalCost = costFabric + costSize + costColor;

            return TotalCost;

            
        }

        /// <summary>
        /// Claculate Cost based on size
        /// </summary>
        /// <param name="sizePriceList"></param>
        /// <param name="sizeCostStrategy"></param>
        /// <param name="tshirt"></param>
        /// <returns></returns>
        public int? CalculateSizeCostPrice(List<SizePriceList> sizePriceList, SizeCostStrategy sizeCostStrategy, Tshirt tshirt)
        {
            int? costSize = sizeCostStrategy.Cost(tshirt);
            return costSize;
        }

        /// <summary>
        /// Calculate Cost Based On Color
        /// </summary>
        /// <param name="colorPriceList"></param>
        /// <param name="colorCostStrategy"></param>
        /// <param name="tshirt"></param>
        /// <returns></returns>
        public int? CalculateColorCostPrice(List<ColorPriceList> colorPriceList, ColorCostStrategy colorCostStrategy, Tshirt tshirt)
        {
            int? costColor = colorCostStrategy.Cost(tshirt);
            return costColor;
        }

        /// <summary>
        /// Calculate Cost Based On Fabric
        /// </summary>
        /// <param name="fabricPriceList"></param>
        /// <param name="fabricCostStrategy"></param>
        /// <param name="tshirt"></param>
        /// <returns></returns>
        public int? CalculateFabricCostPrice(List<FabricPriceList> fabricPriceList, FabricCostStrategy fabricCostStrategy, Tshirt tshirt) 
        {
            int? costFabric = fabricCostStrategy.Cost(tshirt);
            return costFabric;
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
