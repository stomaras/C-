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
            List<TShirt> newShirts = tshirts.ToList();
            Console.WriteLine("Sort - Color - With - QuickSort Asc Works...");
            quickSort(newShirts, 0, newShirts.Count - 1);
            return newShirts;


        }

        public int partition(List<TShirt> tshirts, int low, int high)
        {
            TShirt pivot = tshirts[high];
            // index of smaller element
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // if current element is smaller
                // than the pivot
                if (tshirts[j].Color < pivot.Color)
                {
                    i++;
                    // swap arr[i] and arr[j].
                    TShirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }
            // swap arr[i+1] and arr[high] (or pivot)
            TShirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;
            return i + 1;
        }

        /*
         * The main function that implements QuickSort()
         * arr[] --> Array to be sorted.
         * low --> Starting Index.
         * high --> Ending Index.
         */
        public void quickSort(List<TShirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is now at right place
                 */
                int pi = partition(tshirts, low, high);// divide array in parts.
                // Recursively sort elements before
                // partition and after partition
                quickSort(tshirts, low, pi - 1);
                quickSort(tshirts, pi + 1, high);
            }
        }

        public List<TShirt> SortDesc(List<TShirt> tshirts)
        {
            Console.WriteLine("SortColorWithQuickSort Desc Works...");
            return null;
        }



    }
}
