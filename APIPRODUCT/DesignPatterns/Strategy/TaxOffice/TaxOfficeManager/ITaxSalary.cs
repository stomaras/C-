using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.TaxOffice.TaxOfficeManager
{
    public interface ITaxSalary
    {
        int TaxStrategy(List<Employee> employees);
    }
}
