using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FacadePatterns
{
    public class ProductShopFacade
    {
        public ProductFacade productFacade { get; set; }
        public ShopFacade shopFacade { get; set; }

        public ProductShopFacade()
        {
            productFacade = new ProductFacade();
            shopFacade = new ShopFacade();
        }

        public void CreateCompleteProduct()
        {
            productFacade.SetProduct();
            shopFacade.setShop();
        }
    }
}
