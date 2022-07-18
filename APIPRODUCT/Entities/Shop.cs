﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Shop : SuperMarket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }

        public Shop()
        {
            Products = new HashSet<Product>();  
            Employees = new HashSet<Employee>();
        }

        // Navigation Properties
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
