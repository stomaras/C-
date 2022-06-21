using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.Initializers
{
    internal class MockupDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {

        protected override void Seed(ApplicationDbContext context)
        {
            #region Private School Seed

            #region Student Seed
            Student s1 = new Student() { FirstName = "Spyros", LastName = "Tomaras", DateOfBirth = new DateTime(1997, 11, 01), TuitionFees = 2100, Country = Country.Greece };
            Student s2 = new Student() { FirstName = "Agathi", LastName = "Tomara", DateOfBirth = new DateTime(1999, 11, 01), TuitionFees = 2100, Country = Country.Greece };
            Student s3 = new Student() { FirstName = "Apostolis", LastName = "Papanikoaloy", DateOfBirth = new DateTime(2000, 11, 01), TuitionFees = 2100, Country = Country.Greece };
            Student s4 = new Student() { FirstName = "Marianthi", LastName = "Papanikoaloy", DateOfBirth = new DateTime(2001, 11, 01), TuitionFees = 2100, Country = Country.Greece };
            Student s5 = new Student() { FirstName = "Kostas", LastName = "Fragulis", DateOfBirth = new DateTime(1997, 11, 01), TuitionFees = 2100, Country = Country.Italy };
            Student s6 = new Student() { FirstName = "Nikos", LastName = "Papantonioy", DateOfBirth = new DateTime(1995, 11, 01), TuitionFees = 2100, Country = Country.Italy };
            Student s7 = new Student() { FirstName = "Niki", LastName = "Kall", DateOfBirth = new DateTime(1994, 11, 01), TuitionFees = 2100, Country = Country.Portugal };
            Student s8 = new Student() { FirstName = "Kostantina", LastName = "Fragulis", DateOfBirth = new DateTime(1990, 11, 01), TuitionFees = 2100, Country = Country.Spain };
            Student s9 = new Student() { FirstName = "Kwstas", LastName = "Karaoulanis", DateOfBirth = new DateTime(1997, 11, 04), TuitionFees = 2100, Country = Country.Spain };
            Student s10 = new Student() { FirstName = "Xristos", LastName = "Kanoulas", DateOfBirth = new DateTime(1997, 11, 01), TuitionFees = 2100, Country = Country.France };
            Student s11 = new Student() { FirstName = "Nikolas", LastName = "Kanoulas", DateOfBirth = new DateTime(1990, 11, 07), TuitionFees = 2100, Country = Country.Greece };
            #endregion

            #region Trainer Seed
            Trainer t1 = new Trainer() { FirstName = "Hector", LastName = "Gatsos", Subject = "csharp" };
            Trainer t2 = new Trainer() { FirstName = "George", LastName = "Pasparaks", Subject = "java" };
            Trainer t3 = new Trainer() { FirstName = "Periklis", LastName = "Aidinopoylos", Subject = "python" };
            Trainer t4 = new Trainer() { FirstName = "Bozas", LastName = "Panagiotis", Subject = "javascript" };
            #endregion

            #region Course Seed
            Course c1 = new Course() { Title = "Java", Stream = "Full Time", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022,10,28) };
            Course c2 = new Course() { Title = "Java", Stream = "Part Time", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 06, 28) };
            Course c3 = new Course() { Title = "Csharp", Stream = "Full Time", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 10, 28) };
            Course c4 = new Course() { Title = "Csharp", Stream = "Part Time", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 06, 28) };
            Course c5 = new Course() { Title = "Javascript", Stream = "Full Time", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 06, 28) };
            Course c6 = new Course() { Title = "Javascript", Stream = "Part Time", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 10, 28) };
            Course c7 = new Course() { Title = "Pyhon", Stream = "Full Time", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 06, 28) };
            Course c8 = new Course() { Title = "Python", Stream = "Part Time", Start_Date = new DateTime(2022, 02, 28), End_Date = new DateTime(2022, 10, 28) };
            #endregion

            #region Assigment Seed
            Assigment as1 = new Assigment() { Description = "Front-End", SubDateTime = new DateTime(2022, 03, 28) };
            Assigment as2 = new Assigment() { Description = "Part-A", SubDateTime = new DateTime(2022, 04, 28) };
            Assigment as3 = new Assigment() { Description = "Part-B", SubDateTime = new DateTime(2022, 05, 28) };
            Assigment as4 = new Assigment() { Description = "Assigment-4", SubDateTime = new DateTime(2022, 06, 28) };
            Assigment as5 = new Assigment() { Description = "Assigment-5", SubDateTime = new DateTime(2022, 07, 28) };
            Assigment as6 = new Assigment() { Description = "Assigment-6", SubDateTime = new DateTime(2022, 08, 28) };
            Assigment as7 = new Assigment() { Description = "Assigment-7", SubDateTime = new DateTime(2022, 09, 28) };
            Assigment as8 = new Assigment() { Description = "Group-Project", SubDateTime = new DateTime(2022, 10, 28) };
            Assigment as9 = new Assigment() { Description = "Front-End", SubDateTime = new DateTime(2022, 03, 15) };
            Assigment as10 = new Assigment() { Description = "Part-A", SubDateTime = new DateTime(2022, 03, 28) };
            Assigment as11 = new Assigment() { Description = "Part-B", SubDateTime = new DateTime(2022, 04, 15) };
            Assigment as12 = new Assigment() { Description = "Assigment-4", SubDateTime = new DateTime(2022, 04, 28) };
            Assigment as13 = new Assigment() { Description = "Assigment-5", SubDateTime = new DateTime(2022, 05, 15) };
            Assigment as14= new Assigment() { Description = "Assigment-6", SubDateTime = new DateTime(2022, 05, 28) };
            Assigment as15 = new Assigment() { Description = "Assigment-7", SubDateTime = new DateTime(2022, 06, 15) };
            Assigment as16 = new Assigment() { Description = "Group-Project", SubDateTime = new DateTime(2022, 06, 28) };
            #endregion

            #region Course With Students
            c1.Students = new List<Student>() { s1, s2 };
            c2.Students = new List<Student>() { s3, s4 };
            c3.Students = new List<Student>() { s5, s6 };
            c4.Students = new List<Student>() { s7 };
            c5.Students = new List<Student>() { s8 };
            c6.Students = new List<Student>() { s9 };
            c7.Students = new List<Student>() { s10 };
            c8.Students = new List<Student>() { s11 };
            #endregion

            #region Course With Assigments
            c1.Assigments = new List<Assigment>() { as1, as2, as3, as4, as5, as6, as7, as8 };
            c2.Assigments = new List<Assigment>() { as9, as10, as11, as12, as13, as14, as15, as16 };
            c3.Assigments = new List<Assigment>() { as1, as2, as3, as4, as5, as6, as7, as8 };
            c4.Assigments = new List<Assigment>() { as9, as10, as11, as12, as13, as14, as15, as16 };
            c5.Assigments = new List<Assigment>() { as1, as2, as3, as4, as5, as6, as7, as8 };
            c6.Assigments = new List<Assigment>() { as9, as10, as11, as12, as13, as14, as15, as16 };
            c7.Assigments = new List<Assigment>() { as1, as2, as3, as4, as5, as6, as7, as8 };
            c8.Assigments = new List<Assigment>() { as9, as10, as11, as12, as13, as14, as15, as16 };
            #endregion


            #region Course With Trainers
            t1.Courses = new List<Course>() { c1, c5 };
            t2.Courses = new List<Course>() { c2, c6 };
            t3.Courses = new List<Course>() { c3, c7 };
            t4.Courses = new List<Course>() { c4, c8 };

            #endregion

            #region Assigments With Students
            s1.Assigments = new List<Assigment>() { as1, as2, as3, as4, as5, as6, as7, as8 };
            s2.Assigments = new List<Assigment>() { as1, as2, as3, as4, as5, as6, as7, as8 };
            s3.Assigments = new List<Assigment>() { as9, as10, as11, as12, as13, as14, as15, as16 };
            s4.Assigments = new List<Assigment>() { as9, as10, as11, as12, as13, as14, as15, as16 };
            s5.Assigments = new List<Assigment>() { as1, as2, as3, as4, as5, as6, as7, as8 };
            s6.Assigments = new List<Assigment>() { as1, as2, as3, as4, as5, as6, as7, as8 };
            s7.Assigments = new List<Assigment>() { as9, as10, as11, as12, as13, as14, as15, as16 };
            s8.Assigments = new List<Assigment>() { as9, as10, as11, as12, as13, as14, as15, as16 };
            s9.Assigments = new List<Assigment>() { as1, as2, as3, as4, as5, as6, as7, as8 };
            s10.Assigments = new List<Assigment>() { as9, as10, as11, as12, as13, as14, as15, as16 };
            s11.Assigments = new List<Assigment>() { as1, as2, as3, as4, as5, as6, as7, as8 };


            #endregion


            #endregion
            context.Students.AddOrUpdate(x => new { x.FirstName, x.LastName }, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11);
            context.Trainers.AddOrUpdate(x => x.FirstName, t1, t2, t3, t4);
            context.Courses.AddOrUpdate(x => x.Title, c1, c2, c3, c4, c5, c6, c7, c8);
            context.Assigments.AddOrUpdate(x => new { x.Description, x.SubDateTime }, as1, as2, as3, as4, as5, as6, as7, as8, as9, as10, as11, as12, as13, as14, as15, as16);

            context.SaveChanges();
            base.Seed(context);

        }
    }
}
