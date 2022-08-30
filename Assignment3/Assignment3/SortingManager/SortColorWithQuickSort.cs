using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.SortingManager
{
    // Manager
    public class SortColorWithQuickSort : ISortingMethodStrategy
    {
        public List<TShirt> SortAsc(List<TShirt> tshirts)
        {
            Console.WriteLine("SortColorWithQuickSort Asc Works...");
            return null;
        }

        public List<TShirt> SortDesc(List<TShirt> tshirts)
        {
            Console.WriteLine("SortColorWithQuickSort Desc Works...");
            return null;
        }
    }
}
