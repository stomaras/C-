
using MVCDAY3.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDAY3.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Display(Name ="First Name Please")]
        [Required(ErrorMessage = "Please Enter Valid Student Name")]
        [MaxLength(100, ErrorMessage = " Please Enter Valid Student Name below of 100 characters long")]
        [MinLength(2, ErrorMessage = " Please Enter Valid Student Name above of 2 characters long")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Valid Student Last Name between 2 and 100 characters long")]
        [MaxLength(100)]
        [MinLength(2)]
        public string LastName { get; set; }

        [Range(15,70)]
        public int Age { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string PhotoUrl { get; set; }

        public Country Country { get; set; }
    }
}