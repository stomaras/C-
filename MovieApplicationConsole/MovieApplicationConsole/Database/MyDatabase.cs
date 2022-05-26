using System;
using System.Collections.Generic;

namespace MovieApplicationConsole
{
    public class MyDatabase
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public List<Director> Directors { get; set; } = new List<Director>();
        public List<Actor> Actors { get; set; } = new List<Actor>();
        public List<Genre> Genres { get; set; } = new List<Genre>();

        public MyDatabase()
        {

            #region Seeding Movies 
            //==================Seeding Movies======================
            Movie m1 = new Movie()
            {
                MovieId = 1,
                Title = "Titanic",
                Duration = 194,
                Price = 9.8,
                ProductionYear = new DateTime(1997, 1, 1),
                Rating = 7.8D,
                Country = Country.Australia
            };
            Movie m2 = new Movie()
            {
                MovieId = 2,
                Title = "Inception",
                Duration = 148,
                Price = 16,
                ProductionYear = new DateTime(2010, 1, 1),
                Rating = 78.8D,
                Country = Country.Greece
            };
            Movie m3 = new Movie()
            {
                MovieId = 3,
                Title = "Avatar",
                Duration = 162,
                Price = 13.5,
                ProductionYear = new DateTime(2009, 1, 1),
                Rating = 7.8D,
                Country = Country.Spain
            };
            Movie m4 = new Movie()
            {
                MovieId = 4,
                Title = "The Abyss",
                Duration = 171,
                Price = 13,
                ProductionYear = new DateTime(1989, 1, 1),
                Rating = 7.6D,
                Country = Country.Spain
            };
            Movie m5 = new Movie()
            {
                MovieId = 5,
                Title = "The Rock",
                Duration = 170,
                Price = 18,
                ProductionYear = new DateTime(1996, 1, 1),
                Rating = 7.6D,
                Country = Country.Spain
            };
            Movie m6 = new Movie()
            {
                MovieId = 6,
                Title = "Der Name der Rose",
                Duration = 170,
                Price = 18,
                ProductionYear = new DateTime(1986, 1, 1),
                Rating = 7.6D,
                Country = Country.Spain
            };
            Movie m7 = new Movie()
            {
                MovieId = 7,
                Title = "Snoden",
                Duration = 134,
                Price = 18,
                ProductionYear = new DateTime(2016, 1, 1),
                Rating = 7.6D,
                Country = Country.Venezuela
            };
           
            #endregion

            #region Seeding Actors
            //============================Seeding Actors==================================
            Actor a1 = new Actor()
            {
                ActorId = 1,
                FirstName = "Leonardo",
                LastName = "Dicaprio",
                DateOfBirth = new DateTime(1974, 11, 11),
                DateOfDeath = null,
                Salary = 500000,
                Country = Country.Madagascar
            };
            a1.Movies = new List<Movie>() { m1, m2, m3 };
            m1.Actors.Add(a1);
            m2.Actors.Add(a1);
            m3.Actors.Add(a1);

            Actor a2 = new Actor()
            {
                ActorId = 2,
                FirstName = "Kate",
                LastName = "Winslet",
                DateOfBirth = new DateTime(1975, 10, 06),
                DateOfDeath = null,
                Salary = 450000,
                Country = Country.Croatia
            };
            a2.Movies = new List<Movie>() { m1 };
            m1.Actors.Add(a2);

            Actor a3 = new Actor()
            {
                ActorId = 3,
                FirstName = "Billy",
                LastName = "Zane",
                DateOfBirth = new DateTime(1966, 2, 24),
                DateOfDeath = null,
                Salary = 400000,
                Country = Country.Croatia
            };
            a3.Movies = new List<Movie>() { m1 };
            m1.Actors.Add(a3);

            //Actor a4 = new Actor()
            //{
            //    ActorId = 4,
            //    FirstName = "Zoe",
            //    LastName = "Zaldana",
            //    DateOfBirth = new DateTime(1978, 6, 19),
            //    DateOfDeath = null,
            //    Salary = 50000000,
            //    Country = Country.Australia
            //};
            //a4.Movies.Add(m4);
            //a4.Movies.Add(m3);
            //m4.Actors.Add(a4);
            #endregion

            #region Seeding Directors
            //============================Seeding Directors=============================
            Director d1 = new Director()
            {
                DirectorId = 1,
                FirstName = "James",
                LastName = "Caameron",
                DateOfBirth = new DateTime(1954, 9, 16),
                DateOfDeath = null,
                Country = Country.USA
            };
            d1.Movies = new List<Movie>() { m1, m4, m5 };
            m1.Director = d1;
            m4.Director = d1;
            m5.Director = d1;

            Director d2 = new Director()
            {
                DirectorId = 2,
                FirstName = "Quentin",
                LastName = "Tarantino",
                DateOfBirth = new DateTime(1963, 3, 27),
                DateOfDeath = null,
                Country = Country.USA
            };
            d2.Movies = new List<Movie>() { m3 };
            m3.Director = d2;

            Director d3 = new Director()
            {
                DirectorId = 3,
                FirstName = "Christofer",
                LastName = "Nolan",
                DateOfBirth = new DateTime(1970, 6, 30),
                DateOfDeath = null,
                Country = Country.USA
            };
            d3.Movies = new List<Movie>() { m2 };
            m2.Director = d3;




            #endregion

            #region Seeding Genres
            //=======================Seeding Genres=========================
            Genre g1 = new Genre() { Kind = "Drama" };
            Genre g2 = new Genre() { Kind = "Comdey" };
            Genre g3 = new Genre() { Kind = "Action" };
            Genre g4 = new Genre() { Kind = "Adventure" };
            Genre g5 = new Genre() { Kind = "Crime" };
            Genre g6 = new Genre() { Kind = "Biography" };
            Genre g7 = new Genre() { Kind = "Horror" };


            #endregion

            #region Add Movies To Genres
            //=====================Add Movies To Genres===============================
            g1.Movies = new List<Movie>() { m1 };
            g2.Movies = new List<Movie>() { m3 };
            g3.Movies = new List<Movie>() { m2, m4, m6 };
            g4.Movies = new List<Movie>() { m5 };
            g5.Movies = new List<Movie>() { m7 };
            g6.Movies = new List<Movie>() { m7 };
            g7.Movies = new List<Movie>() { m2 };

            #endregion

            #region Add Genres To Movies
            m1.Genres.Add(g1);
            m3.Genres.Add(g2);
            m2.Genres.Add(g3);
            m2.Genres.Add(g7);
            m4.Genres.Add(g3);
            m6.Genres.Add(g3);
            m7.Genres.Add(g5);
            m7.Genres.Add(g6);
            #endregion

            #region PopulateLists
            List<Movie> movies = new List<Movie>() { m1, m2, m3, m4, m5, m6, m7 };
            Movies.AddRange(movies);

            List<Actor> actors = new List<Actor>() { a1, a2, a3};
            Actors.AddRange(actors);

            List<Director> directors = new List<Director>() { d1, d2, d3 };
            Directors.AddRange(directors);

            List<Genre> genres = new List<Genre>() { g1, g2, g3, g4, g5, g6, g7 };
            Genres.AddRange(genres);
            #endregion
        }
    }
}
