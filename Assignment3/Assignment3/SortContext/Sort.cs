using Assignment3.Enums;
using Assignment3.Models;
using Assignment3.SortingManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.SortContext
{
    //Context
    public class Sort
    {
        private ISortingMethodStrategy sortMethodStrategy;
        public List<TShirt> SetSortingMethod(ISortingMethodStrategy strategy, SortMethod method, List<TShirt> shirts)
        {
            sortMethodStrategy = strategy;
            List<TShirt> newTshirts = new List<TShirt>();
            if (method == SortMethod.ASC)
            {
                newTshirts = SortByAsc(shirts);
            }
            else if (method == SortMethod.DESC)
            {
                newTshirts = SortByDesc(shirts);
            }
            return newTshirts;
        }

        public List<TShirt> SortByAsc(List<TShirt> shirts)
        {
            Console.WriteLine("I am SortByAsc of Context...");
            return sortMethodStrategy.SortAsc(shirts);
        }

        public List<TShirt> SortByDesc(List<TShirt> shirts)
        {
            Console.WriteLine("I am SortByDesc of context");
            return sortMethodStrategy.SortDesc(shirts);
        }
    }


}
