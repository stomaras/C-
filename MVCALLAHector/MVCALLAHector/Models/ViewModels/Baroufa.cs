using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCALLAHector.Models.ViewModels
{
    public class Baroufa
    {
        public string Title { get; set; }
        public List<Student> Students { get; set; }
        public List<Employee> Employees { get; set; }
        public int StudentsCount { get; set; }
        public int EmployeesCount { get; set; }


    }
}