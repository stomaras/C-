using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFinal.DTOS
{
    public class CreateProductDTO
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public int ShopId { get; set; }
        
    }
}