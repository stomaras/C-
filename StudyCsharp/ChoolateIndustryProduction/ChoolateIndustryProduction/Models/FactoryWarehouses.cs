using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoolateIndustryProduction.Interfaces;

namespace ChoolateIndustryProduction.Models
{
    class FactoryWarehouses
    {
        public int FactoryWarehouse_ID { get; set; }
        public string FactoryWarehouseName { get; set; }
        public List<IChocolate> Chocolates { get; set; }
    }
}
