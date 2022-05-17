using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateIndustry.Models;
using ChocolateIndustry.Repository;


namespace ChocolateIndustry.Repository
{
    class FactoryMockRepository
    {

        public static List<Factory> AddFactories(int numOfFactories)
        {
            List<Factory> factories = new List<Factory>();
            for(int i=0; i<= numOfFactories-1; i++)
            {
                if(i == 0)
                {
                    Factory factory = new Factory();
                    factories.Add(factory);
                }
                else
                {
                    Factory factory = new Factory();
                    factories = factory.GenerateUniqueFactory(factory, factories);
                }
               
            }
            return factories;
        }

            
    }
}
