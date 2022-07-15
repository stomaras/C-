using DesignPatterns.Strategy.TaxOffice.TaxOfficeManager;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.TaxOffice.TaxOfficeContext
{
    public class TaxOfficeContext
    {
        ITaxSalary strategy;

        public TaxOfficeContext(ITaxSalary str)
        {
            strategy = str;
        }

        public void CalculateProfits(List<Employee> employees)
        {
            strategy.TaxStrategy(employees);
        }
    }
}
