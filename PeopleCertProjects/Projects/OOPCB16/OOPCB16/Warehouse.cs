using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCB16
{
    class Warehouse
    {
        // Properties
        public int ID { get; set; }

        public string Name { get; set; }

        public Warehouse() { }
        public Warehouse(string name, int ID)
        {
            Name = name;
            this.ID = ID;
        }

        // Constructors

        // Methods
        public Product FindAndReturnProduct(int productID)
        {
            Product product = new Product();

            return product;
        }

        // I call this method  on object -  Warehouse Object
        public Product GetBestProduct()
        {
            Product bestProduct = new Product("Lg Screen", 2);
            return bestProduct;
        }
    }
}
