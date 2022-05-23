using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoolateIndustryProduction.Models;
using ChoolateIndustryProduction.Services;

namespace ChoolateIndustryProduction.Models
{
    class Company
    {
        public int NumOfFactories { get; set; }
        public int NumOfShops { get; set; }
        public int NumOfChocolates { get; set; }

        public int NumOfFactoryEmployees { get; set; }
        public int NumOfShopEmployees { get; set; }
        public int NumOfSuppliers { get; set; }

        public Company(int numOfFactories, int numOfShops, int numOfChocolates)
        {
            NumOfFactories = numOfFactories;
            NumOfShops = numOfShops;
            NumOfChocolates = numOfChocolates;
           
        }

        public void Start()
        {
            for(int i=0; i<= NumOfFactories-1; i++)
            {

                Factory factory = new Factory(RandomService.RandFactoryName());
            }
        }
    }
}
