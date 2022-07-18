using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFinal.DTOS.ShopDTO;

namespace WebFinal.Controllers.APIControllers
{
    public class ShopAPIController : BaseClassController
    {
        // GET: ShopAPI
        [HttpGet]
        public ActionResult GetAllShops()
        {
            var shops = superMarket.Shops.GetAll().Select(x => new ReadShopDTO { Title = x.Title, Address = x.Address });
            return Json(shops, JsonRequestBehavior.AllowGet);
        }
    }
}