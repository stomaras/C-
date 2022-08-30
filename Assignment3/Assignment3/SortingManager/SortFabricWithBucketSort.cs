using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.SortingManager
{
    public class SortFabricWithBucketSort : ISortingMethodStrategy
    {
        public List<TShirt> SortAsc(List<TShirt> tshirts)
        {
            Console.WriteLine("SortFabricWithBucketSort Asc Works...");
            return null;
        }

        public List<TShirt> SortDesc(List<TShirt> tshirts)
        {
            Console.WriteLine("SortFabricWithBucketSort Desc Works...");
            return null;
        }
    }
}
