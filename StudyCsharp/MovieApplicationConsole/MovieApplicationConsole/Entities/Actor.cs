using System;
using System.Collections.Generic;

namespace MovieApplicationConsole
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public double Salary { get; set; }
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

        // Relations
        // Actor has a Country
        public Country Country { get; set; }

        // Actor has a List of Movies
        public List<Movie> Movies { get; set; }

        public void Print()
        {
            int? deathyear;
            if (!DateOfDeath.HasValue)
            {
                deathyear = null;
            }
            else
            {
                deathyear = DateOfDeath.Value.Year;
            }

            Console.WriteLine($"{ActorId,-5}{FirstName,-25}{LastName,-15}{DateOfBirth.Year,-15}{Salary,-15}{Age,-10}{deathyear,-10}");
        }

        public void PrintName()
        {
            Console.WriteLine($"{FirstName,-15}{LastName,-15}");
        }

        public void PrintNameAndCountry()
        {
            Console.WriteLine($"{FirstName,-15}{LastName,-15}{Country,-15}");
        }
    }
}
