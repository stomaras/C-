using System;
using System.Collections.Generic;

namespace MovieApplicationConsole
{
    /*
     * Movie has one Director
     * Movie has several Genres
     * Movie has several Actors
     * Movie has a Country
     * 
     */
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public double Rating { get; set; }
        public DateTime ProductionYear { get; set; }
        public int Duration { get; set; }
        public double? Price { get; set; }//Nullable because a movie may not have a price

        // Movie has a Country
        public Country Country { get; set; }

        // Navigation Properties

        // Movie has many Actors
        public List<Actor> Actors { get; set; } = new List<Actor>();

        // Movie will have Many Genre
        public List<Genre> Genres { get; set; } = new List<Genre>();

        // Movie has a Director
        public Director Director { get; set; } = new Director();

        public void Print()
        {
            Console.WriteLine($"{MovieId,-5}{Title,-25}{Country,-15}{Rating,-10}{ProductionYear.Year,-10}{Duration,-10}{Price,-10}");
        }

        public void PrintTitle()
        {
            Console.WriteLine($"{Title,-25}");
        }
    }
}
