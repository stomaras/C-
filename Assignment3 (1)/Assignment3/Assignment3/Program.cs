using Assignment3.Enums;
using Assignment3.EshopContext;
using Assignment3.Models;
using Assignment3.PaymentMethodStrategyManager;
using Assignment3.SortContext;
using Assignment3.SortingManager;
using Assignment3.VariationStrategyManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IVariationStrategy> ShopNormalVariation = new List<IVariationStrategy>()
            {
                new ColorVariationNormalStrategy(),
                new FabricVariationNormalStrategy(),
                new SizeVariationNormalStrategy(),
            };

            TShirt t1 = new TShirt(Color.Indigo, Size.M,Fabric.Silk);
            TShirt t2 = new TShirt(Color.Blue, Size.XXL, Fabric.Linen);
            TShirt t3 = new TShirt(Color.Orange, Size.L, Fabric.Polyester);
            TShirt t4 = new TShirt(Color.Yellow, Size.M, Fabric.Wool);
            TShirt t5 = new TShirt(Color.Yellow, Size.XS, Fabric.Cashmere);
            TShirt t6 = new TShirt(Color.Blue, Size.M, Fabric.Linen);
            TShirt t7 = new TShirt(Color.Blue, Size.L, Fabric.Polyester);
            TShirt t8 = new TShirt(Color.Blue, Size.S, Fabric.Rayon);
            TShirt t9 = new TShirt(Color.Violet, Size.XXXL, Fabric.Polyester);
            TShirt t10 = new TShirt(Color.Blue, Size.XXL, Fabric.Linen);

            List<TShirt> shirts = new List<TShirt>() { t1,t2,t3,t4,t5,t6,t7,t8,t9,t10 };
            //Menu
            Console.WriteLine("1 - Size Asc : Bubble Sort");
            Console.WriteLine("2 - Size Desc : Bubble Sort");
            Console.WriteLine("3 - Color Asc : Quick Sort");
            Console.WriteLine("4 - Color Desc : Quick Sort Sort");
            Console.WriteLine("5 - Fabric Asc : Bucket Sort");
            Console.WriteLine("6 - Fabric Desc : Bucket Sort");
            Console.WriteLine("7 - Size-Color-Fabric Asc : Linq");
            Console.WriteLine("8 - Size-Color-Fabric Desc : Linq");
            Console.WriteLine("9 - Size-Color-Fabric Asc: Bubble Sort");
            Console.WriteLine("10 - Size-Color-Fabric Desc : Bubble Sort");

            // User Input
            string choice = Console.ReadLine();
            Sort sort = new Sort();

            List<TShirt> sortedList = null;

            switch (choice)
            {
                case "1": 
                    sortedList = sort.SetSortingMethod(new SortSizeWithBubble(),SortMethod.ASC,shirts);
                    break;
                case "2": 
                    sortedList = sort.SetSortingMethod(new SortSizeWithBubble(), SortMethod.DESC,shirts);
                    break;
                case "3": 
                    sortedList = sort.SetSortingMethod(new SortColorWithQuickSort(), SortMethod.ASC,shirts);
                    break;
                case "4": 
                    sortedList = sort.SetSortingMethod(new SortColorWithQuickSort(),SortMethod.DESC,shirts);
                    break;
                case "5": 
                    sortedList = sort.SetSortingMethod(new SortFabricWithBucketSort(),SortMethod.ASC,shirts);
                    break;
                case "6": 
                    sortedList = sort.SetSortingMethod(new SortFabricWithBucketSort(), SortMethod.DESC, shirts);
                    break;
                case "7": 
                    sortedList = sort.SetSortingMethod(new SortSizeColorFabricWithLinq(), SortMethod.ASC, shirts);
                    break;
                case "8": 
                    sortedList = sort.SetSortingMethod(new SortSizeColorFabricWithLinq(), SortMethod.DESC, shirts);
                    break;
                case "9": 
                    sortedList = sort.SetSortingMethod(new SortSizeColorFabricWithBubbleSort(), SortMethod.ASC, shirts);
                    break;
                case "10": 
                    sortedList = sort.SetSortingMethod(new SortSizeColorFabricWithBubbleSort(),SortMethod.DESC, shirts);
                    break;
                default:
                    break;
            }


            Print(shirts);
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Print(sortedList);
            //var shop = new EShop();
            //shop.SetPriceListVariation(ShopNormalVariation);
            //var totalPrice = shop.CalculateCost(t1);

            //shop.SetPaymentMethod(new BankStrategy());
            //shop.PayTshirt(totalPrice);


        }

        public static void Print(List<TShirt> shirts)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Size",-10}{"Color",-10}{"Fabric",-10}");
            Console.ResetColor();
            foreach (var shirt in shirts)
            {
                Console.WriteLine($"{shirt.Size,-10}{shirt.Color,-10}{shirt.Fabric,-10}");
            }
        }
    }
}

/*
 * Quick Sort Methodology 
 * QuickSort calls from program.cs or a controller
 * call method partition.
 * takes some data and call herself, and call herself again
 * 
 * Quick Sort 
 * This sorting Algorithm uses the idea of divide and conquer.
 * 
 * It finds the element called PIvot which divides the array into two halves
 * in such a way that elements in the left half are smaller than pivot and elements 
 * in the right hand are greater than pivot.
 * 
 * We recursively perform three steps:
 * 1) Bring the pivot to its appropriate position such that left of the pivot is smaller 
 * and right is greater.
 * 
 * 2) Quick Sort the left part.
 * 3) Quick Sort the right part.
 * 
 * Partition
 * 4 7 2 6 3 5 9
 * 
 * Select whichever element you want in the array.
 * Compare every element which is smaller than the selected. put this on left.
 * Compare every element which is bigger than the selected. put this on right.
 * Do the same for left partition and for the right partition.
 * 
 * Worst scenatrio of quick sort is when all elements are the same.
 * 
 * 
 * 
 * 
 * 
 */
