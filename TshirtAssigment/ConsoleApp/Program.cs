﻿using MyDatabase;
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

            var fabricPriceList = unit.FabricPriceList.GetAll();
            var colorPriceList = unit.ColorPriceList.GetAll();
            var sizePriceList = unit.SizePriceList.GetAll();

            Console.WriteLine("\n");
            Console.WriteLine("Fabric Price List:\n");
            foreach (var item in fabricPriceList)
            {
                Console.WriteLine($" Price : ${item.Price}, Fabric :{item.Fabric}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Color Price List:\n");
            foreach (var item1 in colorPriceList)
            {
                Console.WriteLine($" Price : ${item1.Price}, Color :{item1.Color}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Size Price List:\n");
            foreach (var item2 in sizePriceList)
            {
                Console.WriteLine($" Price : ${item2.Price}, Size :{item2.Size}");
            }
            
        }
    }
}