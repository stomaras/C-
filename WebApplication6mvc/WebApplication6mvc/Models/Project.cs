using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication6mvc.Models.CustomValidations;

namespace WebApplication6mvc.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        [Display(Name = "Title Of Project")]
        [Required(ErrorMessage ="You must give a title")]
        [CustomValidation(typeof(MyValidationsMethods), "ValidateFirstCapitalLetter")]
        public string Title { get; set; }

        public Project()
        {
            Employees = new HashSet<Employee>();
        }

        // Navigation Properties
        public ICollection<Employee> Employees { get; set; }
    }
}