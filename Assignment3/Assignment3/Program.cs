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
            TShirt t5 = new TShirt(Color.Yellow, Size.XXL, Fabric.Cashmere);
            TShirt t6 = new TShirt(Color.Blue, Size.M, Fabric.Linen);
            TShirt t7 = new TShirt(Color.Blue, Size.L, Fabric.Linen);
            TShirt t8 = new TShirt(Color.Blue, Size.S, Fabric.Linen);
            TShirt t9 = new TShirt(Color.Violet, Size.XXXL, Fabric.Polyester);
            TShirt t10 = new TShirt(Color.Blue, Size.XXL, Fabric.Linen);

            List<TShirt> shirts = new List<TShirt>() { t1,t2,t3,t4,t5,t6,t7,t8,t9,t10 };
            //Menu
            Console.WriteLine("1 - Size Asc : Bubble Sort");
            Console.WriteLine("2 - Size Desc : Bubble Sort");
            Console.WriteLine("3 - Color Asc : Quick Sort");
            Console.WriteLine("4 - Color Desc : Quick Sort Sort");
            Console.WriteLine("5 - Size Asc : Bucket Sort");
            Console.WriteLine("6 - Size Desc : Bucket Sort");
            Console.WriteLine("7 - Size-Color-Fabric Asc : Linq");
            Console.WriteLine("8 - Size-Color-Fabric Desc : Linq");
            Console.WriteLine("9 - Size-Color-Fabric Asc: Bubble Sort");
            Console.WriteLine("10 - Size-Color-Fabric Desc : Bubble Sort");

            // User Input
            string choice = Console.ReadLine();
            Sort sort = new Sort();
            switch (choice)
            {
                case "1": sort.SetSortingMethod(new SortSizeWithBubble()).Invoke(shirts);break;
                case "2": sort.SetSortingMethod(new SortSizeWithBubble()).Invoke(shirts);break;
                case "3": Console.WriteLine("3");break;
                case "4": Console.WriteLine("4");break;
                case "5": Console.WriteLine("5");break;
                case "6": Console.WriteLine("6");break;
                case "7": Console.WriteLine("7");break;
                case "8": Console.WriteLine("8");break;
                case "9": Console.WriteLine("9");break;
                case "10": Console.WriteLine("10");break;
                default:
                    break;
            }


            Print(shirts);
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
                Console.WriteLine($"{shirt.Size,-10}{shirt.Color,-10}{shirt.Size,-10}");
            }
        }
    }
}
