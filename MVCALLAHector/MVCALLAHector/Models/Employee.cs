using MVCALLAHector.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCALLAHector.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name="Full Name")]
        [Required(ErrorMessage = "Give a name ")]
        [MaxLength(20, ErrorMessage ="Give a name less than 20 characters")]
        [MinLength(3,ErrorMessage ="Give a name more than 2 characters")]
        public string Name { get; set; }

        [Range(0,50000)]
        public double Salary { get; set; }

        [Range(15,140)]
        public int Age { get; set; }

        [Display(Name = "Hire Date")]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:yyyy-MM-dd}")]
        public DateTime HireDate { get; set; }
        public Country Country { get; set; }

        public string PhotoUrl { get; set; }


        public Employee()
        {
            Managers = new HashSet<Manager>();
        }




        // Foreign Keys
        public int ProjectId { get; set; }

        // Navigation Properties
        public Project Project { get; set; }

        public ICollection<Manager> Managers { get; set; }
    }
}