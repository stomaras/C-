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

        public IEnumerable<SizePriceList> CalculateSumTshirtCost(Tshirt tshirt)
        {

            var sizePriceListStrategy = GetSizePriceList();
            var colorRriceListStrategy = GetColorPriceList();
            var fabricPriceListStrategy = GetFabricPriceList();

            // for to find tshirt color

            // select with linq to find tshirt size

            // select with linq to find tshirt fabric

            //return sizeColorStrategy;
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
