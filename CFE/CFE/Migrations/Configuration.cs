namespace CFE.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CFE.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CFE.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            Student s1 = new Student() { Name = "Tom", Salary = 1200 };
            Student s2 = new Student() { Name = "Chris", Salary = 1200 };
            Student s3 = new Student() { Name = "Zarma", Salary = 1200 };
            Student s4 = new Student() { Name = "Xristos", Salary = 1200 };

            // update in case if exists and insert in case if does not exists
            // can not ind ID in this point does not has role in comparison ... in comparsion we have name
            context.Students.AddOrUpdate(s => s.Name, s1, s2, s3);
            context.SaveChanges();


            //Synthetic Employees 

            Employee e1 = new Employee() { Name = "Hector" };
            Employee e2 = new Employee() { Name = "TOM" };
            Employee e3 = new Employee() { Name = "Xristos" };
            Employee e4 = new Employee() { Name = "Bill" };

            context.Employees.AddOrUpdate(s => s.Name, e1, e2, e3, e4);
            context.SaveChanges();
        }
    }
}
