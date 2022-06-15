using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCALLAHector.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Kind { get; set; }

        public Genre()
        {
            Movies = new HashSet<Movie>();
        }

        // Navigation Properties
        public ICollection<Movie> Movies { get; set; }  
    }
}