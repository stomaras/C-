using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StrategyPatterns.TaxOfficeManager
{
    public interface ITaxStrategy
    {
        List<double> CalculateTaxs(List<Employee> employees);
    }
}
