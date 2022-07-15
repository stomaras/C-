using Entities;
using Patterns.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StrategyPatterns.TaxOfficeManager
{
    public class HighTaxStrategy : ITaxStrategy
    {
        public List<int> CalculateTaxs(List<Employee> employees)
        {
            throw new NotImplementedException();
        }

        /*
         * Delegates For Calculate Amount Of Tax for each use case
         * 
         */
    }
}
