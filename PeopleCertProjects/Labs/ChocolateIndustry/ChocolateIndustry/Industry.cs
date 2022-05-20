using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateIndustry.Interfaces;
using ChocolateIndustry.Models;
using ChocolateIndustry.Repository;
using ChocolateIndustry.Services;

namespace ChocolateIndustry
{
    class Industry
    {

        public List<string> ShopNames { get; set; }
        public List<string> StreetNames { get; set; }
        public List<string> AreaNames { get; set; }

        public Industry()
        {

        }

        public void Start()
        {
            //int numOfProducts = 10;
            //Supplier supplier = new Supplier(numOfProducts);
            //Console.WriteLine(supplier);

            //Supplier supplier1 = new Supplier(3);
            //Console.WriteLine(supplier1);


            InputServiceShopEntity inputServiceShopEntity = new InputServiceShopEntity();
            ShopNames = inputServiceShopEntity.ShopNames;
            StreetNames = inputServiceShopEntity.StreetNames;
            AreaNames = inputServiceShopEntity.Areas;
            string name = RandomService.RandShopName(ShopNames);
            string street = RandomService.RandStreetName(StreetNames);
            string area = RandomService.RandAreaName(AreaNames);
            Shop shop = new Shop(name, street, area);

            // Print Shop Names
            //InputService inputService = new InputService();
            //ShopNames = inputService.ShopNames;
            //PrintService.PrintShopNames(ShopNames);

            
            
            
            //Console.WriteLine("Enter number between 0-10:\n");
            //int action;
            //string s = Console.ReadLine();
            //action = CheckService.EnterValidNumberBetween0And10(s);
            //while (action >= 0 && action <=10)
            //{
            //    switch (action)
            //    {
            //        case 0:
            //            // Enter Available Options
            //            PrintService.PrintProgramOptions();
            //            break;
            //        case 1:
            //        // Enter Industry Number Of Chocolates
            //        default:
            //            // Exit the program
            //            action = -1;
            //            break;
            //    }
            //    if(action != -1)
            //    {

            //        s = Console.ReadLine();
            //        action = CheckService.EnterValidNumberBetween0And10(s);
            //    }
            //}

        }
    }
}
