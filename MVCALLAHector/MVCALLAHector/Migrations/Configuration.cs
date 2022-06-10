namespace MVCALLAHector.Migrations
{
    using MVCALLAHector.Models;
    using MVCALLAHector.Models.Enums;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCALLAHector.MyContext.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVCALLAHector.MyContext.ApplicationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            #region Student Seeding
            Student s1 = new Student() { Name = "Hector", Age = 34 };
            Student s2 = new Student() { Name = "Marios", Age = 27 };
            Student s3 = new Student() { Name = "Damianos", Age = 15 };

            context.Students.AddOrUpdate(x => x.Name, s1, s2, s3);
            context.SaveChanges();
            #endregion

            #region Employee Seeding

            Project p1 = new Project() { Title = "C#" };
            Project p2 = new Project() { Title = "Java" };
            Project p3 = new Project() { Title = "Pyhon" };



            Employee e1 = new Employee() { Name = "Tom", Age=24, Country=Country.Greece, HireDate = new DateTime(2015, 5, 6), Salary = 12000, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjI0MTg3MzI0M15BMl5BanBnXkFtZTcwMzQyODU2Mw@@._V1_UY1200_CR130,0,630,1200_AL_.jpg" };
            Employee e2 = new Employee() { Name = "Agathi", Age=22, Country=Country.Greece, HireDate = new DateTime(2017, 5, 6), Salary = 9000, PhotoUrl = "https://yt3.ggpht.com/CN8OQyUJm7xDFoEg_HaY3AsPBgkw1eKcRbbasPIVyQPrJy0Tvn6_WJoK7rkQMX6QQDE7lNc-=s900-c-k-c0x00ffffff-no-rj" };
            Employee e3 = new Employee() { Name = "Apostolis", Age=21, Country=Country.Greece, HireDate = new DateTime(2018, 5, 6), Salary = 3000, PhotoUrl = "https://i.pinimg.com/originals/03/39/8f/03398f6a50dd131b306d7209c5a9d0fa.jpg" };

            e1.Project = p1;
            e2.Project = p2;
            e3.Project = p3;


            // UPSERT Operation
            context.Employees.AddOrUpdate(e => e.Name, e1, e2, e3);
            context.SaveChanges();
            #endregion



        }
    }
}
