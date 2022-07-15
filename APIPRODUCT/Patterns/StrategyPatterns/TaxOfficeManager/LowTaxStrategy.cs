using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StrategyPatterns.TaxOfficeManager
{
    public class LowTaxStrategy : ITaxStrategy
    {
        

        

        public List<int> CalculateTaxs(List<Employee> employees)
        {
            Dictionary<int, int> factors = GetFactorsOfTax(employees);
            throw new NotImplementedException();
        }

        public Dictionary<int, int> GetFactorsOfTax(List<Employee> employees)
        {
            var incomes = employees.Select(x => x.AnnualIncome).ToList();
            var numOfKids = employees.Select(x => x.NumOfKids).ToList();

           
            Dictionary<int, int> factors = new Dictionary<int, int>();
            for (int i = 0; i < employees.Count; i++)
            {
                factors.Add(numOfKids[i], incomes[i]);
            }
            return factors;

        }

        /*
         * Delegates For Calculate Amount Of Tax for each use case
         * 
         */



    }
}
