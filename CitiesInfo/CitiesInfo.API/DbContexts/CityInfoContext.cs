﻿using CitiesInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CitiesInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        
        public DbSet<City> Cities { get; set; } = null!;

        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;


        public CityInfoContext(DbContextOptions<CityInfoContext> options) 
            : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("connectionstring");
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasData(
                new City("New York City")
                {
                    Id = 1,
                    Description = "The one with that big park."
                },
                new City("Antwerp")
                {
                    Id = 2,
                    Description = "The one with the cathedral that was never really finished"
                },
                new City("Paris")
                {
                    Id = 3,
                    Description = "The one with that big tower"
                });

            modelBuilder.Entity<PointOfInterest>()
                .HasData(
                    new PointOfInterest("Central Park")
                    {
                        Id = 1,
                        CityId = 1,
                        Description = "The most visited urban park in the United States"
                    },
                    new PointOfInterest("Empire State Building")
                    {
                        Id = 2,
                        CityId = 1,
                        Description = "A 102-story skyscrapper located in Midtown Manhattan"
                    },
                    new PointOfInterest("Cathedral")
                    {
                        Id = 3,
                        CityId = 2,
                        Description = "a Gothic style cathedral, conceived by architects"
                    },
                    new PointOfInterest("Eiffel Tower")
                    {
                        Id = 4,
                        CityId = 3,
                        Description = "A wrought iron lattice tower on the Champ de Mars"
                    },
                    new PointOfInterest("The Lourve")
                    {
                        Id = 5,
                        CityId = 3,
                        Description = "The world's largest museum"
                    }                
                    );
            base.OnModelCreating(modelBuilder);

        }

    }
}
