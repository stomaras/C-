using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCALLAHector.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }

        // Foreign Keys
        public int? GenreId { get; set; }

        // Navigation Properties
        public Genre Genre { get; set; }
    }
}