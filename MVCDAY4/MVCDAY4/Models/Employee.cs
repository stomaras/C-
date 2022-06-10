using MVCDAY4.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDAY4.Models
{
    public class Employee
    {

        
        public int EmployeeId { get; set; }

        [Display(Name ="First Name")]
        [Required(ErrorMessage = "Give a First Name")]
        [MaxLength(20, ErrorMessage ="Give a First Name less than 20 characters")]
        [MinLength(3, ErrorMessage ="Give a First Name more then 2 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Give a Last Name")]
        [MaxLength(20, ErrorMessage = "Give a Last Name less than 20 characters")]
        [MinLength(3, ErrorMessage = "Give a Last Name more then 2 characters")]
        public string LastName { get; set; }



        [Required(ErrorMessage ="Give a Age")]
        [Range(18,70, ErrorMessage ="Age Must Be Between 18 and 70 years old")]
        public int Age { get; set; }

        [Display(Name =" Birth Date")]
        [Required(ErrorMessage ="Give a Birth Date")]
        public DateTime DateOfBirth { get; set; }

       
        public Country Country { get; set; }

        [Display(Name ="Photo")]
        [Required(ErrorMessage ="Give a Photo")]
        public string PhotoUrl { get; set; }


    }
}