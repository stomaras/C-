using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoolateIndustryProduction.Interfaces;
using ChoolateIndustryProduction.Services;

namespace ChoolateIndustryProduction.Models
{
    class Supplier
    {
        public static int Supplier_ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int NumOfSupplierChocolates { get; private set; }

        public Supplier(string FirstName, string LastName)
        {
            GenerateSupplierID();
            this.FirstName = FirstName;
            this.LastName = LastName;
            NumOfSupplierChocolates = GetNumOfChocolates();

        }

        public int GetNumOfChocolates()
        {
            return RandomService.Number(50, 1000);
        }

        public static void GenerateSupplierID()
        {
            Supplier_ID++;
        }
    }
}
