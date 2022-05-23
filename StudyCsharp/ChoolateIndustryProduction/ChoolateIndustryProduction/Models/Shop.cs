using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoolateIndustryProduction.Models
{
    class Shop
    {
        public int Shop_id { get; set; }
        public string ShopName { get; set; }
        public List<ShopWarehouses> ShopWarehouses { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Supplier> Suppliers { get; set; }
    }
}
