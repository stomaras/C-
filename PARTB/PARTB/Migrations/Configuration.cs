namespace PARTB.Migrations
{
    using PARTB.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PARTB.Database.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PARTB.Database.ApplicationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            #region Seeding Students
            var students = new List<Student>
            {
                new Student { FirstName = "Spyros", LastName = "Tomaras", DateOfBirth =  new DateTime(1997, 11, 01), TuitionFees = 2100 },
                new Student { FirstName = "Agathi", LastName = "Tomaras", DateOfBirth = new DateTime(1999, 11, 01), TuitionFees = 2100 },
                new Student { FirstName = "Chris", LastName = "Fragulis", DateOfBirth =  new DateTime(1997, 12, 15), TuitionFees = 2100 },
                new Student { FirstName = "Natalia", LastName = "Zacharaki", DateOfBirth =  new DateTime(1997, 02, 16), TuitionFees = 2100 },
                new Student { FirstName = "Natalia", LastName = "Kallifoni", DateOfBirth =  new DateTime(2002, 11, 01), TuitionFees = 2100 },
                new Student { FirstName = "Anna", LastName = "Kallifoni", DateOfBirth =  new DateTime(2000, 11, 01), TuitionFees = 2100 },
                new Student { FirstName = "Apostolis", LastName = "Papanikolaoy", DateOfBirth =  new DateTime(2000, 11, 01), TuitionFees = 2100 },
                new Student { FirstName = "Xristoforos", LastName = "Kallifoni", DateOfBirth =  new DateTime(1995, 11, 01), TuitionFees = 2100 },
                new Student { FirstName = "Chris", LastName = "Fragulis", DateOfBirth =  new DateTime(1995, 11, 01), TuitionFees = 2100 },
                new Student { FirstName = "Kostas", LastName = "Fragulis", DateOfBirth =  new DateTime(1995, 11, 01), TuitionFees = 2100 },
                new Student { FirstName = "George", LastName = "Zarmakoupes", DateOfBirth =  new DateTime(1995, 11, 01), TuitionFees = 2100 },
                new Student { FirstName = "Bill", LastName = "Oikonomidis", DateOfBirth =  new DateTime(1995, 11, 01), TuitionFees = 2100 },
                new Student { FirstName = "Xristos", LastName = "Kanoulas", DateOfBirth =  new DateTime(1995, 11, 01), TuitionFees = 2100 },
                new Student { FirstName = "Yiannis", LastName = "Karakasis", DateOfBirth =  new DateTime(1995, 11, 01), TuitionFees = 2100 },
                new Student { FirstName = "Mitsos", LastName = "Noulas", DateOfBirth =  new DateTime(1995, 11, 01), TuitionFees = 2100 },
                new Student { FirstName = "Niki", LastName = "Kallifoni", DateOfBirth =  new DateTime(1995, 11, 01), TuitionFees = 2100 },
                new Student { FirstName = "Natale", LastName = "Giannakopoyloy", DateOfBirth =  new DateTime(1995, 11, 01), TuitionFees = 2100 },
                new Student { FirstName = "Kassiani", LastName = "Liokaytoy", DateOfBirth =  new DateTime(1995, 11, 01), TuitionFees = 2100 },
                new Student { FirstName = "Eleanna", LastName = "Kakochristoy", DateOfBirth =  new DateTime(1995, 11, 01), TuitionFees = 2100 },
                new Student { FirstName = "Georgia", LastName = "Silli", DateOfBirth =  new DateTime(1995, 11, 01), TuitionFees = 2100 },
            };


            #endregion

            #region Seeding Trainers
            var trainers = new List<Trainer>
            {
                new Trainer() { FirstName = "Hector", LastName = "Gatsos", Subject = "C#" },
                new Trainer() { FirstName = "George", LastName = "Pasparakis", Subject = "Java" },
                new Trainer() { FirstName = "Periklis", LastName = "Aidinopoulos", Subject = "Python" },
                new Trainer() { FirstName = "Panos", LastName = "Bozas", Subject = "Javascript" },
                new Trainer() { FirstName = "Mark", LastName = "Zuckerberg", Subject = "c#" },
                new Trainer() { FirstName = "Linus", LastName = "Torvalds", Subject = "Java" },
                new Trainer() { FirstName = "Bill", LastName = "Gates", Subject = "Python" },
                new Trainer() { FirstName = "Nikos", LastName = "Epaminondas", Subject = "Javascript" },
            };

            #endregion

            #region Seeding Assigments
            var assigments = new List<Assigment>
            {
                new Assigment() { Title = "Part A", Description = "Front End", SubDateTime = new DateTime(2022, 03, 28), OralMark = 20, TotalMark = 100, Courses = new List<Course>() },
                new Assigment() { Title = "Part B", Description = "Back End", SubDateTime = new DateTime(2022, 04, 28), OralMark = 20, TotalMark = 100, Courses = new List<Course>()  },
                new Assigment() { Title = "Part C", Description = "Databases", SubDateTime = new DateTime(2022, 05, 28), OralMark = 20, TotalMark = 100, Courses = new List<Course>()  },
                new Assigment() { Title = "Part D", Description = "Design Patters", SubDateTime = new DateTime(2022, 06, 28), OralMark = 20, TotalMark = 100, Courses = new List<Course>()  },
            };
            #endregion

            #region Seeding Courses
            var courses = new List<Course>
            {
                new Course() { Title = "Full Time", Type = "Java", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 05, 28) },
                new Course() { Title = "Part Time", Type = "Java", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 09, 28)},
                new Course() { Title = "Full Time", Type = "C#", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 05, 28)},
                new Course() { Title = "Part Time", Type = "C#", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 09, 28)},
                new Course() { Title = "Full Time", Type = "Python", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 05, 28)},
                new Course() { Title = "Part Time", Type = "Python", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 09, 28)},
                new Course() { Title = "Full Time", Type = "Javascript", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 05, 28)},
                new Course() { Title = "Part Time", Type = "Javascript", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 09, 28)},
            };

            #endregion

            #region Aggregation Courses With Students
            students[0].Course = courses[0];
            students[1].Course = courses[1];
            students[2].Course = courses[2];
            students[3].Course = courses[3];
            students[4].Course = courses[4];
            students[5].Course = courses[5];
            students[6].Course = courses[6];
            students[7].Course = courses[7];
            students[8].Course = courses[0];
            students[9].Course = courses[0];
            students[10].Course = courses[1];
            students[11].Course = courses[1];
            students[12].Course = courses[7];
            students[13].Course = courses[7];
            students[14].Course = courses[7];
            students[15].Course = courses[0];
            students[16].Course = courses[4];
            students[17].Course = courses[4];
            students[18].Course = courses[4];
            students[19].Course = courses[5];

            #endregion

            #region Aggregation Courses With Trainers
            trainers[0].Course = courses[0];
            trainers[1].Course = courses[1];
            trainers[2].Course = courses[2];
            trainers[3].Course = courses[3];
            trainers[4].Course = courses[2];
            trainers[5].Course = courses[1];
            trainers[6].Course = courses[0];
            trainers[7].Course = courses[3];
            #endregion

            #region Aggregation Courses With Assigments
            courses[0].Assigments.Add(assigments[0]);
            courses[0].Assigments.Add(assigments[1]);
            courses[0].Assigments.Add(assigments[2]);
            courses[0].Assigments.Add(assigments[3]);
            courses[1].Assigments.Add(assigments[0]);
            courses[1].Assigments.Add(assigments[1]);
            courses[1].Assigments.Add(assigments[2]);
            courses[1].Assigments.Add(assigments[3]);
            courses[2].Assigments.Add(assigments[0]);
            courses[2].Assigments.Add(assigments[1]);
            courses[2].Assigments.Add(assigments[2]);
            courses[2].Assigments.Add(assigments[3]);
            courses[3].Assigments.Add(assigments[0]);
            courses[3].Assigments.Add(assigments[1]);
            courses[3].Assigments.Add(assigments[2]);
            courses[3].Assigments.Add(assigments[3]);
            courses[4].Assigments.Add(assigments[0]);
            courses[4].Assigments.Add(assigments[1]);
            courses[4].Assigments.Add(assigments[2]);
            courses[4].Assigments.Add(assigments[3]);
            courses[5].Assigments.Add(assigments[0]);
            courses[5].Assigments.Add(assigments[1]);
            courses[5].Assigments.Add(assigments[2]);
            courses[5].Assigments.Add(assigments[3]);
            courses[6].Assigments.Add(assigments[0]);
            courses[6].Assigments.Add(assigments[1]);
            courses[6].Assigments.Add(assigments[2]);
            courses[6].Assigments.Add(assigments[3]);
            courses[7].Assigments.Add(assigments[0]);
            courses[7].Assigments.Add(assigments[1]);
            courses[7].Assigments.Add(assigments[2]);
            courses[7].Assigments.Add(assigments[3]);
            
            
            #endregion

            #region Create Database
            students.ForEach(s => context.Students.AddOrUpdate(p => p.FirstName, s));
            trainers.ForEach(t => context.Trainers.AddOrUpdate(p => p.LastName, t));
            assigments.ForEach(t => context.Assigments.AddOrUpdate(p => p.Description, t));
            courses.ForEach(t => context.Courses.AddOrUpdate(p => p.Title, t));
            //trainers.ForEach(s => context.Trainers.AddOrUpdate(t => t.FirstName, s));
            //assigments.ForEach(s => context.Assigments.AddOrUpdate(p => p.Description, s));
            context.SaveChanges();
            #endregion

        }
    }
}
