using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.SortingManager
{
    public class SortSizeWithBubble : ISortingMethodStrategy
    {
        public List<TShirt> SortAsc(List<TShirt> tshirts)
        {
            Console.WriteLine("SortSizeWithBubble Asc Works\n");
            return null;
        }

        public List<TShirt> SortDesc(List<TShirt> tshirts)
        {
            Console.WriteLine("SortSizeWithBubble Desc Works\n");
            return null;
        }
    }
}
