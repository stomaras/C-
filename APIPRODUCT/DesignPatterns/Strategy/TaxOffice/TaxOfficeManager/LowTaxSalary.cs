using Entities;
using MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.TaxOffice.TaxOfficeManager
{
    public class LowTaxSalary : ITaxSalary
    {
        public int TaxStrategy(List<Employee> employees)
        {

            return 0;
            
        }


        
    }
}
