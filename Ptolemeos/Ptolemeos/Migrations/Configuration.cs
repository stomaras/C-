namespace Ptolemeos.Migrations
{
    using System;
    using Ptolemeos.Entities;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    

    internal sealed class Configuration : DbMigrationsConfiguration<Ptolemeos.MyDatabase.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Ptolemeos.MyDatabase.ApplicationContext context)
        {
            //  This method will be called after migrating to the latest version.


            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            // Realistic data
            Student s1 = new Student("Hector", 99);
            Student s2 = new Student("Maria", 87);
            Student s3 = new Student("Sofia", 66);


            // Upsert
            context.Students.AddOrUpdate(s => s.Name, s1, s2, s3);
            context.SaveChanges();
        }
    }
}
