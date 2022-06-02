namespace SchoolPartBFinal.Migrations
{
    using SchoolPartBFinal.Entities;
    using System;
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
            Student s1 = new Student("Spyros", "Tom");
            Student s2 = new Student("Agathi", "Tom");
            Student s3 = new Student("Apostolis", "Pap");


            // Upsert
            context.Students.AddOrUpdate(s => s.FirstName, s1, s2, s3);
            context.SaveChanges();
        }
    }
}
