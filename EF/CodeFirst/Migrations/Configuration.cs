namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirst.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            Student s1 = new Student() { Name = "Hector" };
            Student s2 = new Student() { Name = "Spyros" };
            Student s3 = new Student() { Name = "Chris" };
            Student s4 = new Student() { Name = "Zarma" };
            Student s5 = new Student() { Name = "Kanoulas" };

            context.Students.Add(s1);
            context.Students.Add(s2);
            context.Students.Add(s3);

            context.SaveChanges();

            // Create, Edit or Update, Delete, Read (UPSERT update or insert)
            // compare every student in the database if has the same name with the student which is going to add
            // if has different name add this student, else does not add this tudent
            context.Students.AddOrUpdate(s=>s.Name, s1,s2,s3);

        }
    }
}
