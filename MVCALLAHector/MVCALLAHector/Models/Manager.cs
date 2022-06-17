using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCALLAHector.Models
{
    public class Manager
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Manager()
        {
            Employees = new HashSet<Employee>();
        }


        //Navigation Properties
        //virtual -> lazy loading
        public ICollection<Employee> Employees { get; set; }
    }
}