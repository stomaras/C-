using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCALLAHector.Models.ViewModels
{
    public class MovieGenres
    {
        public string Title  { get; set; }

        public List<Movie> Movies { get; set; }
        public List<Genre> Genres { get; set; }
    }
}