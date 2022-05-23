using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoolateIndustryProduction.Interfaces;
using ChoolateIndustryProduction.Services;

namespace ChoolateIndustryProduction.Models
{
    class Factory
    {

        public static int Fid { get; set; }
        public string FactoryName { get; set; }
        public List<FactoryWarehouses> FactoryWarehouses { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<Employee> Employees { get; set; }
        public int NumOfSuppliers { get; set; }
        public int NumOfEmployees { get; set; }
        public int NumOfFactoryWarehouses { get; set; }
        public int NumOfTotalChocolates { get; set; }

        public Factory(string factoryName)
        {
            GenerateFactoryID();
            FactoryName = factoryName;
            NumOfSuppliers = RandomService.Number(1, 4);
            NumOfEmployees = RandomService.Number(1, 200);
            NumOfFactoryWarehouses = RandomService.Number(1, 10);
            for (int i = 0; i < NumOfSuppliers-1; i++)
            {
                Supplier supplier = new Supplier(RandomService.RandFirstName(), RandomService.RandLastName());
                NumOfTotalChocolates += supplier.NumOfSupplierChocolates;
            }
            Suppliers = new List<Supplier>();
            Employees = new List<Employee>();
            FactoryWarehouses = new List<FactoryWarehouses>();
        }

        public static void GenerateFactoryID()
        {
            Fid++;
        }


    }
}
