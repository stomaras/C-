using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebFinal.Controllers.APIControllers
{
    public class ProductAPIController : BaseClassController
    {
        // GET: ProductAPI
        [HttpGet]
        public ActionResult GetAllProducts()
        {
            var products = superMarket.Products.GetAll();
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        [HttpDelete]
        public ActionResult DeleteProduct(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var product = superMarket.Products.GetById(id);
            //if (product == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            //}
            //superMarket.Products.Delete(product);
            //superMarket.Complete();
            return Json(product, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                superMarket.Products.Insert(product);
                superMarket.Complete();
                return Json(product, JsonRequestBehavior.AllowGet);
            }
            return Json(product, JsonRequestBehavior.AllowGet);
        }



        [HttpGet]
        public ActionResult GetProductById(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = superMarket.Products.GetById(id);
            if (product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            return Json(product, JsonRequestBehavior.AllowGet);
        }

        [HttpPut]
        public ActionResult UpdateProduct(int? id, Product product)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var productToUpdate = superMarket.Products.GetById(id);
            if (productToUpdate == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price;
            productToUpdate.Quantity = product.Quantity;

            if (ModelState.IsValid)
            {
                superMarket.Products.Update(productToUpdate);
                superMarket.Complete();
                return Json(productToUpdate, JsonRequestBehavior.AllowGet);

            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);            
        }
    }
}