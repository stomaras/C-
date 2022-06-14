using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication6mvc.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        [Display(Name = "Title Of Project")]
        public string Title { get; set; }

        public Project()
        {
            Employees = new HashSet<Employee>();
        }

        // Navigation Properties
        public ICollection<Employee> Employees { get; set; }
    }
}