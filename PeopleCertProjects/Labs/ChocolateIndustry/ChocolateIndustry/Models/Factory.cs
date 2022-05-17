using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateIndustry.Models;
using ChocolateIndustry.Services;

namespace ChocolateIndustry.Models
{
    class Factory
    {

        private static int _fid;

        public static int Fid
        {
            get { return _fid; }
            set { _fid = value; }
        }

        private string _factoryName;

        public string FactoryName
        {
            get { return _factoryName; }
            set { _factoryName = value; }
        }



        public Factory()
        {
            GenerateId();
            FactoryName = RandomService.RandFactoryName();
        }

        public static int GenerateId()
        {
            return Fid++;
        }

        public List<Factory> GenerateUniqueFactory(Factory factory, List<Factory> factories)
        {
            bool isUnique = false;
            while (!isUnique)
            {
                int count = 0;
                for (int i = 0; i <= factories.Count - 1; i++)
                {
                    
                    if (factory.FactoryName.Equals(factories[i].FactoryName))
                    {
                        count++;
                    }
                }
                if(count > 0)
                {
                    factory = new Factory();// generate a new factory
                } else
                {
                    isUnique = true;
                    factories.Add(factory);
                }
            }
            return factories;
        }

        public override string ToString()
        {
            return $" Factory {{ Fid {Fid}, Name : {FactoryName}}}";
        }





    }
}
