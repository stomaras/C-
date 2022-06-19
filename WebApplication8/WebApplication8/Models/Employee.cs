using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage="First Name Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Age Required")]
        public int Age { get; set; }

        [Required(ErrorMessage ="Hire Date Required")]
        public DateTime HireDate { get; set; }

        [Required(ErrorMessage ="Salary Required")]
        public int Salary { get; set; }

        [Required(ErrorMessage ="Country Required")]
        public Country Country { get; set; }

        public Employee()
        {
            Managers = new HashSet<Manager>();
        }



        // Foreign Keys 
        public int? ProjectId { get; set; }

        // Navigation Properties
        public Project Project { get; set; }

        public ICollection<Manager> Managers { get; set; }


    }
}