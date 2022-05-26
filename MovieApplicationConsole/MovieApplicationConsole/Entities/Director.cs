using System;
using System.Collections.Generic;

namespace MovieApplicationConsole
{
    public class Director
    {
        public int DirectorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public int Age
        {
            get
            {
                if (DateOfDeath.HasValue)
                {
                    return DateOfDeath.Value.Year - this.DateOfBirth.Year;
                }
                else
                {
                    return DateTime.Now.Year - this.DateOfBirth.Year;
                }
            }
        }

        // A Director has a Country
        public Country Country { get; set; }

        // Navigation Properties

        // Director has a List of Movies
        public List<Movie> Movies { get; set; }

        // Methods
        public void Print()
        {
            int? deathYear;
            if (!DateOfDeath.HasValue)
            {
                deathYear = null;
            }
            else
            {
                deathYear = DateOfDeath.Value.Year;
            }
            Console.WriteLine($"{DirectorId,-5}{FirstName,-15}{LastName,-15}{Country,-10}{DateOfBirth.Year,-10}{deathYear,-10}{Age,-10}");
        }

        public void PrintName()
        {
            Console.WriteLine($"{FirstName,-15}{LastName,-15}");
        }
    }
}
