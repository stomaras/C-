using MVCALLAHector.Models.CustomValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCALLAHector.Models
{
    public class Genre
    {
        public int GenreId { get; set; }


        [Required(ErrorMessage ="Title of Genre Cannot be Empty")]
        [CustomValidation(typeof(MyValidationMethods), "ValidateOfGenre")]
        public string Kind { get; set; }

        public Genre()
        {
            Movies = new HashSet<Movie>();
        }

        // Navigation Properties
        public ICollection<Movie> Movies { get; set; }  
    }
}