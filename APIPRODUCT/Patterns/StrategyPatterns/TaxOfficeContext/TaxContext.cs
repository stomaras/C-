using Entities;
using Patterns.DAL;
using Patterns.StrategyPatterns.TaxOfficeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StrategyPatterns.TaxOfficeContext
{
    public class TaxContext : DataAccess
    {
        ITaxStrategy strategy;

        public TaxContext(ITaxStrategy str)
        {
            strategy = str;
        }

        public int CalculateTaxs()
        {
            DataAccess dataAccess = new DataAccess();
            var emps = (List<Employee>)dataAccess.superMarket.Employees.GetAll();
            foreach (var employee in emps)
            {
                Console.WriteLine(employee.FirstName);
            }
            return strategy.CalculateTaxs(emps);
        }
    }
}
