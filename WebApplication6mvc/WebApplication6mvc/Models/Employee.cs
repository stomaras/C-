using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication6mvc.Models.Enums;

namespace WebApplication6mvc.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage ="Max Characters of First Name must be at most 80 characters long")]
        [MinLength(3, ErrorMessage = "Min Characters of First Name must be at least 3 characters long")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Max Characters of Last Name must be at most 80 characters long")]
        [MinLength(3, ErrorMessage = "Min Characters of Last Name must be at least 3 characters long")]
        public string LastName { get; set; }

        [Required]
        [Range(18,70, ErrorMessage ="Age of Employees must be between <<18 and 70>> yeaars old")]
        public int Age { get; set; }

        [Required]
        [Display(Name ="Hire Date")]
        public DateTime HireDate { get; set; }

        [Required]
        public Country Country { get; set; }


    }
}