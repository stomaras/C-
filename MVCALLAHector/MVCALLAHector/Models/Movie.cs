using MVCALLAHector.Models.CustomValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCALLAHector.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Title field cannot be empty")]
        [MaxLength(200, ErrorMessage ="Title cannot be more than 100 characters long")]
        [MinLength(3, ErrorMessage ="Title cannot be less than 3 characters long")]
        public string Title { get; set; }


        [Required(ErrorMessage ="Price field cannot be empty")]
        public double Price { get; set; }


        [Required(ErrorMessage ="Rating field cannot be empty")]
        [Range(1,10,ErrorMessage ="Rating must be a number between <<1 and 10>>")]
        public double Rating { get; set; }

        // Foreign Keys
        public int? GenreId { get; set; }

        // Navigation Properties
        public Genre Genre { get; set; }
    }
}