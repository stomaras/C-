using DesignPatterns.EshopStrategy;
using DesignPatterns.MainContext;
using Entities;
using Entities.Enums;
using MyDatabase;
using Repositories.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            MyApplicationContext myApplicationContext = new MyApplicationContext();
            UnitOfWork unit = new UnitOfWork(myApplicationContext);

            var tshirts = unit.Tshirt.GetAll().ToList();

            //foreach (var tshirt in tshirts)
            //{
            //    Console.WriteLine(tshirt.Mark);
            //}

            var fabricPriceList = unit.FabricPriceList.GetAll();
            var colorPriceList = unit.ColorPriceList.GetAll();
            var sizePriceList = unit.SizePriceList.GetAll();
            List<int?> itemsFinalCost = new List<int?>();
            //Console.WriteLine("\n");
            //Console.WriteLine("Fabric Price List:\n");
            //foreach (var item in fabricPriceList)
            //{
            //    Console.WriteLine($" Price : ${item.Price}, Fabric :{item.Fabric}");
            //}

            //Console.WriteLine("\n");
            //Console.WriteLine("Color Price List:\n");
            //foreach (var item1 in colorPriceList)
            //{
            //    Console.WriteLine($" Price : ${item1.Price}, Color :{item1.Color}");
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("Size Price List:\n");
            //foreach (var item2 in sizePriceList)
            //{
            //    Console.WriteLine($" Price : ${item2.Price}, Size :{item2.Size}");
            //}
            //Tshirt tshirt = new Tshirt() {Mark = Mark.Adidas, Color = Color.GREEN, Fabric = Fabric.LINEN, Size = Size.XL };
            IVariationStrategy variationStrategy = new SizeCostStrategy();
            EShopContext eshopContext = new EShopContext(new SizeCostStrategy());
            foreach (var tshirt in tshirts)
            {
                int? finalCost = eshopContext.CalculateSumTshirtCost(tshirt);
                itemsFinalCost.Add(finalCost);
            }

            for (int i = 0; i < itemsFinalCost.Count; i++)
            {
                Console.WriteLine($"Item with name ${tshirts[i].Mark} with color ${tshirts[i].Color} with size ${tshirts[i].Size} with fabric ${tshirts[i].Fabric} with final cost ${itemsFinalCost[i]}");
            }

            //foreach (var item in priceListSize)
            //{
            //    Console.WriteLine(item.Price);
            //    Console.WriteLine(item.Size);
            //}

        }
    }
}
