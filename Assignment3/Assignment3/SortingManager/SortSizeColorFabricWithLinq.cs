using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.SortingManager
{
    public class SortSizeColorFabricWithLinq : ISortingMethodStrategy
    {
        public List<TShirt> SortAsc(List<TShirt> tshirts)
        {
            Console.WriteLine("SortSizeColorFabricWithLinq Asc Works...");
            return null;
        }

        public List<TShirt> SortDesc(List<TShirt> tshirts)
        {
            Console.WriteLine("SortSizeColorFabricWithLinq Desc Works...");
            return null;
        }
    }
}
