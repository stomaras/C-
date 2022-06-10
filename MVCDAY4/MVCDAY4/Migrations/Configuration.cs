namespace MVCDAY4.Migrations
{
    using MVCDAY4.Models;
    using MVCDAY4.Models.Enums;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCDAY4.Data.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVCDAY4.Data.ApplicationContext context)
        {
            Employee e1 = new Employee() { FirstName = "Charly", LastName = "Jordan", Age = 21, DateOfBirth = new DateTime(1999, 11, 09), Country = Country.France, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjI0MTg3MzI0M15BMl5BanBnXkFtZTcwMzQyODU2Mw@@._V1_UY1200_CR130,0,630,1200_AL_.jpg" };
            Employee e2 = new Employee() { FirstName = "Agathi", LastName = "Tomara", Age = 22, DateOfBirth = new DateTime(1999, 11, 02), Country = Country.Greece, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjI0MTg3MzI0M15BMl5BanBnXkFtZTcwMzQyODU2Mw@@._V1_UY1200_CR130,0,630,1200_AL_.jpg" };
            Employee e3 = new Employee() { FirstName = "Apostolis", LastName = "Papanikolaoy", Age = 21, DateOfBirth = new DateTime(2000, 11, 01), Country = Country.Greece, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjI0MTg3MzI0M15BMl5BanBnXkFtZTcwMzQyODU2Mw@@._V1_UY1200_CR130,0,630,1200_AL_.jpg" };
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Employees.AddOrUpdate(e => e.FirstName, e1, e2, e3);
            context.SaveChanges();
        }
    }
}
