using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StrategyPatterns.TaxOfficeManager
{
    public class MediumTaxStrategy : ITaxStrategy
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
