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
            Console.WriteLine("Sort Size With Bubble Asc Works...\n");
            Console.WriteLine();

            //Copy the List in order to return a new ones.
            List<TShirt> newTshirts = tshirts.ToList(); 
            
            TShirt temp;
            for (int j = 0; j <= newTshirts.Count - 2; j++)
            {
                for (int i = 0; i <= newTshirts.Count - 2; i++)
                {
                    if (newTshirts[i].Size > newTshirts[i+1].Size)
                    {
                        temp = newTshirts[i + 1];
                        newTshirts[i + 1] = newTshirts[i];
                        newTshirts[i] = temp;
                    }
                }
            }
            
            return newTshirts;
        }

        public List<TShirt> SortDesc(List<TShirt> tshirts)
        {
            Console.WriteLine("Sort Size With Bubble Desc Works...\n");

            
            Console.WriteLine();

            //Copy the List in order to return a new ones.
            List<TShirt> newTshirts = tshirts.ToList();

            TShirt temp;
            for (int j = 0; j <= newTshirts.Count - 2; j++)
            {
                for (int i = 0; i <= newTshirts.Count - 2; i++)
                {
                    if (newTshirts[i].Size < newTshirts[i + 1].Size)
                    {
                        temp = newTshirts[i + 1];
                        newTshirts[i + 1] = newTshirts[i];
                        newTshirts[i] = temp;
                    }
                }
            }

            return newTshirts;
            return null;
        }
    }
}
