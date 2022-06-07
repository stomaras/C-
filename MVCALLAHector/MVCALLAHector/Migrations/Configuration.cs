namespace MVCALLAHector.Migrations
{
    using MVCALLAHector.Models;
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
            Student s1 = new Student() { Name = "Hector", Age = 34 };
            Student s2 = new Student() { Name = "Marios", Age = 27 };
            Student s3 = new Student() { Name = "Damianos", Age = 15 };

            context.Students.AddOrUpdate(x => x.Name, s1, s2, s3);
            context.SaveChanges();
        }
    }
}
