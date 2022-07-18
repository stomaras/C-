using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFinal.DTOS.EmployeeDTO
{
    public class ReadEmployeeDTO
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int annualIncome { get; set; }
        public int numOfKids { get; set; }

        public double amountOfTax { get; set; }
    }
}