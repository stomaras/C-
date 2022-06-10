using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCALLAHector.Models.Queries
{
    public class EmployeeSearchQuery// Data Transfer Object
    {
        public string searchName { get; set; }
        public string searchCountry { get; set; }
        public int? searchMin { get; set; }
        public int? searchMax { get; set; }
    }
}