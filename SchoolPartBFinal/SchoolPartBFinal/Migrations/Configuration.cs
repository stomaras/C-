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
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
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
            students.ForEach(s => context.Students.AddOrUpdate(p => p.FirstName, s));
            context.SaveChanges();
            


            
            
        }
    }
}
