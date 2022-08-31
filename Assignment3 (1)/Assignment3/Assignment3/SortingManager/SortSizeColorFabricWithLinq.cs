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
            Console.WriteLine();
            Console.WriteLine("Sort - Size - Color - Fabric - With - Linq Asc Works...");
            Console.WriteLine();


            return tshirts.OrderBy(x=>x.Size).ThenBy(x=>x.Color).ThenBy(x=>x.Fabric).ToList();
        }

        public List<TShirt> SortDesc(List<TShirt> tshirts)
        {
            Console.WriteLine();
            Console.WriteLine("Sort - Size - Color - Fabric - With - Linq Desc Works...");
            Console.WriteLine();
            return tshirts
                .OrderByDescending(x=>x.Size)
                .ThenByDescending(x=>x.Color)
                .ThenByDescending(x=>x.Fabric).ToList();
        }
    }
}
