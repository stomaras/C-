using System.Collections.Generic;

namespace MovieApplicationConsole
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Kind { get; set; }

        // Navigation Properties
        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
}
