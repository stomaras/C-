namespace MVCDay2Begin.Migrations
{
    using MVCDay2Begin.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCDay2Begin.Data.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVCDay2Begin.Data.ApplicationContext context)
        {

            #region Seeding Student
            Student s1 = new Student() { FirstName = "Charly", LastName = "Jordan", DateOfBirth = new DateTime(1999,11,01), PhotoUrl = "https://yt3.ggpht.com/CN8OQyUJm7xDFoEg_HaY3AsPBgkw1eKcRbbasPIVyQPrJy0Tvn6_WJoK7rkQMX6QQDE7lNc-=s900-c-k-c0x00ffffff-no-rj" };
            Student s2 = new Student() { FirstName = "Ester", LastName = "Exposito", DateOfBirth = new DateTime(1997,11,01), PhotoUrl = "https://image.tmdb.org/t/p/w500/6wsOvUn9YewNZ3IEEBWfiDVTYOc.jpg" };
            Student s3 = new Student() { FirstName = "Agbani", LastName = "Darego", DateOfBirth = new DateTime(2000,1,01), PhotoUrl = "https://buzznigeria.com/wp-content/uploads/2015/04/Agbani-Darego-1024x931.jpg" };

            context.Students.AddOrUpdate(x => x.FirstName, s1, s2, s3);
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            #endregion

            #region Trainer
            Trainer t1 = new Trainer() { FirstName = "George", LastName = "Pasparakis", Subject = "Java" };
            Trainer t2 = new Trainer() { FirstName = "Hector", LastName = "Gatsos", Subject = "C#" };
            Trainer t3 = new Trainer() { FirstName = "Periklis", LastName = "Aidinopoulos", Subject = "SQL" };
            Trainer t4 = new Trainer() { FirstName = "Panagotis", LastName = "Bozas", Subject = "Javascript" };

            context.Trainers.AddOrUpdate(x => x.FirstName, t1, t2, t3, t4);
            context.SaveChanges();
            #endregion
        }
    }
}
