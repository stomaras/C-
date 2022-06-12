using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCDAY5Web.Models
{
    public class Project
    {
        public int Id { get; set; }

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