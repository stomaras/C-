namespace SchoolPartBFinal.Migrations
{
    using SchoolPartBFinal.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SchoolPartBFinal.Database.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SchoolPartBFinal.Database.ApplicationContext context)
        {

            #region Seeding Students
            var students = new List<Student>
            {
                new Student { FirstName = "Spyros", LastName = "Tomaras", BirthDate = DateTime.Parse("1997-11-01"), TuitionFees = 2100},
                new Student { FirstName = "Nataalia", LastName = "Zacharaki", BirthDate = DateTime.Parse("1997-02-01"), TuitionFees = 2100},
                new Student { FirstName = "Agathi", LastName = "Tomara", BirthDate = DateTime.Parse("1999-11-01"), TuitionFees = 2100},
                new Student { FirstName = "Apostolis", LastName = "Papanikolaoy", BirthDate = DateTime.Parse("2000-11-01"), TuitionFees = 2100},
                new Student { FirstName = "Xristoforos", LastName = "Kallifonis", BirthDate = DateTime.Parse("1995-11-01"), TuitionFees = 2100},
                new Student { FirstName = "Yiannis", LastName = "Karakasis", BirthDate = DateTime.Parse("1981-11-01"), TuitionFees = 2100},

            };

            // Upsert
           
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            #endregion

            #region Seeding Trainers
            var trainers = new List<Trainer>
            {
                new Trainer {FirstName = "George", LastName = "Pasparakis", Subject="Java"},
                new Trainer {FirstName = "Hector", LastName = "Gatsos", Subject="C#"},
                new Trainer {FirstName = "Periklis", LastName = "Aidinopoulos", Subject="SQL"},
                new Trainer {FirstName = "Panagiotis", LastName = "Bozas", Subject="Javascript"},
            };

            trainers.ForEach(t => context.Trainers.AddOrUpdate(p => p.FirstName, t));
            context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            #endregion

            #region Seeding Courses

            Course c1 = new Course { Type = "Java", Stream = "CB16", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 09, 28) };
            Course c2 = new Course { Type = "C#", Stream = "CB16", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 09, 28) };
            Course c3 = new Course { Type = "Python", Stream = "CB16", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 09, 28) };
            Course c4 = new Course { Type = "Javascript", Stream = "CB16", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 09, 28) };


            #endregion

            #region Aggregation Students With Courses
            students[0].Course = c1;
            students[1].Course = c2;
            students[2].Course = c3;
            students[3].Course = c4;


            #endregion

            students.ForEach(s => context.Students.AddOrUpdate(p => p.FirstName, s));
            context.SaveChanges();
            

        }
    }
}
