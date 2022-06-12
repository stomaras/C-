namespace MVCDAY3.Migrations
{
    using MVCDAY3.Models.Enums;
    using MVCDAY3.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCDAY3.Database.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVCDAY3.Database.ApplicationContext context)
        {

            Student s1 = new Student() { FirstName = "Spyros", LastName = "Tomaras", Age = 24 ,DateOfBirth = new DateTime(1997, 11, 01), Country = Country.Greece, PhotoUrl = "https://avatars.githubusercontent.com/u/22882822?v=4" };
            Student s2 = new Student() { FirstName = "Charly", LastName = "Jordan", Age = 22 ,DateOfBirth = new DateTime(1999, 11, 01), Country = Country.Greece, PhotoUrl = "https://everbuster.com/wp-content/uploads/2021/12/Charly-Jordan-%E2%80%93-The-2021-Sports-Illustrated-Awards-1024x1536.jpg" };
            Student s3 = new Student() { FirstName = "Ester", LastName = "Exposito", Age = 23, DateOfBirth = new DateTime(1998, 11, 01), Country = Country.Greece, PhotoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTCrZf-8eodHQVhYe8gGVDLPTCYAAqwnKCTIw&usqp=CAU" };
            Student s4 = new Student() { FirstName = "Agathi", LastName = "Tomara", Age = 24, DateOfBirth = new DateTime(1997, 11, 01), Country = Country.Greece, PhotoUrl = "https://avatars.githubusercontent.com/u/22882822?v=4" };
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Students.AddOrUpdate(s => s.FirstName, s1, s2, s3, s4);
            context.SaveChanges();
        }
    }
}
