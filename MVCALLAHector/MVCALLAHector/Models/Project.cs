using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MVCALLAHector.Models.CustomValidations;

namespace MVCALLAHector.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Display(Name ="Title")]
        [Required(ErrorMessage ="You must give title")]
        [CustomValidation(typeof(MyValidationMethods), "ValidateFirstCapitalLetter")]
        public string Title { get; set; }

        public Project()
        {
            Employees = new HashSet<Employee>();
        }


        // Navigation Properties
        public ICollection<Employee> Employees { get; set; }
    }
}