using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebFinal.DTOS;

namespace WebFinal.Controllers.APIControllers
{
    public class ProductAPIController : BaseClassController
    {
        // GET: ProductAPI

        [HttpGet]
        public ActionResult GetAllProductsChart(int count, string sortOrder)
        {
            var products = superMarket.Products.GetAll().Select(x => new ProductDTO { Id = x.Id, Name = x.Name, Quantity = x.Quantity, Price = x.Price})
                .Take(count);


            switch (sortOrder)
            {
                case "Asc":products = products.OrderBy(x => x.Quantity).ToList(); break;
                case "Desc":products = products.OrderByDescending(x => x.Quantity).ToList();break;        
                default :products = products.OrderBy(x => x.Quantity).ToList(); break;
            }


            return Json(products, JsonRequestBehavior.AllowGet);// Name, Price, Quantity
        }




        [HttpPost]
        public ActionResult CreateProductAggregation(CreateProductDTO createProductDTO, int? shopId)
        {
            if (shopId is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            Product product = new Product();
            product.Name = createProductDTO.productName;
            product.Price = createProductDTO.productPrice;
            product.Quantity = createProductDTO.productQuantity;
            product.Shop = superMarket.Shops.GetById(shopId);
           

           

            if (ModelState.IsValid)
            {
                superMarket.Products.Insert(product);
                superMarket.Complete();
                CreateProductDTO createProductDto = new CreateProductDTO()
                {
                    Id = product.Id,
                    productName = product.Name,
                    productPrice = product.Price,
                    productQuantity = product.Quantity,
                    
                    Shop = new { Title = product.Shop?.Title, Address = product.Shop?.Address ,Id = product.Shop?.Id }
                };
                return Json(createProductDto, JsonRequestBehavior.AllowGet);
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

        
        }



        [HttpPost]
        public ActionResult CreateProduct(ProductDTO dto) // Name, Price, Quantity
        {
            // Mapping
            Product product = new Product();
            product.Name = dto.Name;
            product.Price = dto.Price;
            product.Quantity = dto.Quantity;


            if (ModelState.IsValid)
            {
                superMarket.Products.Insert(product);
                superMarket.Complete();
                return Json(product, JsonRequestBehavior.AllowGet);
            }
            return Json(product, JsonRequestBehavior.AllowGet);
        }






        [HttpGet]
        public ActionResult GetAllProducts()
        {
            var products = superMarket.Products.GetAllProductsWithShops().Select(x => new ProductDTO
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                Quantity = x.Quantity,
                Shop = new { x.Shop?.Title}
            });

            return Json(products, JsonRequestBehavior.AllowGet);// Name, Price, Quantity
        }

        [HttpGet]
        public ActionResult GetProductDetails(int Id)
        {
            var product = superMarket.Products.GetById(Id);

            return Json(product, JsonRequestBehavior.AllowGet);
        }




        [HttpPost]
        public ActionResult DeleteProduct(int? id)
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

            superMarket.Products.Delete(id);
            superMarket.Complete();

            ProductDTO dto = new ProductDTO()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity
            };

            return Json(dto, JsonRequestBehavior.AllowGet);
;
        }





        [HttpGet]
        public ActionResult GetProductById(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = superMarket.Products.GetProductWithShopDetails(id);
            if (product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            ProductDTO productDTO = new ProductDTO()
            {
                Id = product.Id,
                Name = product.Name,
                Quantity = product.Quantity,
                Price = product.Price,
                Shop = new { product.Shop?.Title },
            };

            return Json(productDTO, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateProduct(int? id, ProductDTO dto)
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

            // Mapping
            productToUpdate.Name = dto.Name;
            productToUpdate.Quantity = dto.Quantity;
            productToUpdate.Price = dto.Price;

            

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