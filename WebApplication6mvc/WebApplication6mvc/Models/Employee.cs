using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6mvc.Models.Enums;

namespace WebApplication6mvc.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime HireDate { get; set; }
        public Country Country { get; set; }


    }
}