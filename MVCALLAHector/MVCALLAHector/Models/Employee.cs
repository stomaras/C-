using MVCALLAHector.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCALLAHector.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        public DateTime HireDate { get; set; }
        public Country Country { get; set; }

        public string PhotoUrl { get; set; }
    }
}