using MVCDAY5Web.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDAY5Web.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [MaxLength(100, ErrorMessage = "Max Characters of First Name must be at most 100 characters!")]
        [MinLength(3, ErrorMessage = "Min Characters of First Name must be at least 3 characters!")]
        public string FirstName { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(100, ErrorMessage = "Max Characters of Last Name must be at most 100 characters!")]
        [MinLength(3, ErrorMessage = "Min Characters of Last Name must be at least 3 characters!")]
        public string LastName { get; set; }

        [Required]
        [Range(18,70, ErrorMessage ="Age of Employee must be between <<18 and 70>> years old")]
        public int Age { get; set; }

        [Display(Name ="Hire Date")]
        [Required]
        public DateTime HireDate { get; set; }

        [Required]
        public string Photo { get; set; }

        [Required]
        public Country Country { get; set; }

        [Display(Name = "Full Name")]
        public string FullName 
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        // Foreign Keys
        public int ProjectId { get; set; }


        //Navigation Properties
        public Project Project { get; set; }

    }
}