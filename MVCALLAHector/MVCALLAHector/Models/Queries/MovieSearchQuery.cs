using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCALLAHector.Models.Queries
{
    public class MovieSearchQuery
    {
        public string searchTitle { get; set; }
        public string searchGenre { get; set; }
        public double? searchMinPrice { get; set; }
        public double? searchMaxPrice { get; set; }
    }
}