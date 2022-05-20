using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateIndustry.Services;

namespace ChocolateIndustry.Models
{
    class Product
    {

        public int Product_id { get; private set; }
        public string Name { get; private set; }
        public int Quantity { get; private set; }
        public int Quality { get; private set; }
        public decimal PricePerKg { get; private set; }
        public List<int> ProductIds { get; set; }
        public static int count { get; set; } = 0;


        public Product()
        {

            count++;
            ProductIds = new List<int>();
            if (count == 0)
            {
                int id = RandomService.Number(1, 2001);
                ProductIds.Add(id);
            }
            else
            {
                int id = RandomService.Number(1, 2001);
                Product_id = GenerateUniqueID(id, ProductIds);
            }
            
            Quantity = RandomService.Number(1, 5);
            Name = RandomService.ProductName();
            Quality = RandomService.RandQualityIndex();
            PricePerKg = CalculationPricePerKg(Quantity, Quality);
        }
        

        public static Product GetProduct()
        {
            return new Product();
        }

        public int GenerateUniqueID(int id, List<int> ids)
        {
            bool isUnique = false;
            int count = 0;
            while (!isUnique)
            {
                for(int i=0; i<= ids.Count-1; i++)
                {
                    if (ids[i] == id)
                    {
                        count++;
                        id = RandomService.Number(1, 2001);
                    }
                }
                if(count == 0)
                {
                    isUnique = true;
                    
                }
            }
            return id;
        }
        
        // Calculation of Price Per Kg
        public decimal CalculationPricePerKg(int Quantity, int Quality)
        {
            decimal pricePerKg = (Quantity / 2) * (Quality / 2);
            return pricePerKg;
        }

        public override string ToString()
        {
            string s = $"Product {{Product id {Product_id}, Name {Name}, Quantity {Quantity}, Quality {Quality} }}";
            return s;
        }
    }
}
