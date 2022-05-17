using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateIndustry.Models;
using ChocolateIndustry.Interfaces;
using ChocolateIndustry.Repository;
using ChocolateIndustry.Services;

namespace ChocolateIndustry.Repository
{
    class ChocolateMockRepository
    {

        public static List<IChocolate> AddChocolateSampleData(int numOfChocolates)
        {
            List<IChocolate> chocolates = new List<IChocolate>();
            string name = RandomService.RandName();
            for (int i = 0; i < numOfChocolates - 1; i++)
            {
                
                if (name == "White")
                {
                    WhiteChocolate whiteChocolate = new WhiteChocolate();
                    chocolates.Add(whiteChocolate);
                }
                else if (name == "Black")
                {
                    BlackChocolate blackChocolate = new BlackChocolate();
                    chocolates.Add(blackChocolate);
                }
                else if (name == "Milk")
                {
                    MilkChocolate milkChocolate = new MilkChocolate();
                    chocolates.Add(milkChocolate);
                }
                name = RandomService.RandName();
            }
            return chocolates;
        }
    }
}
