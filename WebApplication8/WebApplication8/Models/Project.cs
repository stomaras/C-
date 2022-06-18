using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Project()
        {
            Employees = new HashSet<Employee>();    
        }

        // Navigation Properties
        public ICollection<Employee> Employees { get; set; }
    }
}