using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFinal.DTOS
{
    public class CreateProductDTO
    {
        public int Id { get; set; }
        public string productName { get; set; }
        public int productPrice { get; set; }
        public int productQuantity { get; set; }
        public object Shop { get; set; }
    }
}