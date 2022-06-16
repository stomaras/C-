using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCALLAHector.Models;
using System.Data.Entity.Migrations;
using MVCALLAHector.Models.Enums;

namespace MVCALLAHector.MyContext.Initializers
{
    public class MockupDBInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
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
            Project p4 = new Project() { Title = "Sql" };
            Project p5 = new Project() { Title = "Angular" };
            Project p6 = new Project() { Title = "NET" };
            Project p7 = new Project() { Title = "Spring" };
            Project p8 = new Project() { Title = "C" };
            Project p9 = new Project() { Title = "C++" };
            Project p10 = new Project() { Title = "CSS" };
            Project p11 = new Project() { Title = "React" };
            Project p12 = new Project() { Title = "Vue" };
            Project p13 = new Project() { Title = "JQuery" };



            Employee e1 = new Employee() { Name = "Tom", Age = 24, Country = Country.Greece, HireDate = new DateTime(2015, 5, 6), Salary = 12000, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjI0MTg3MzI0M15BMl5BanBnXkFtZTcwMzQyODU2Mw@@._V1_UY1200_CR130,0,630,1200_AL_.jpg" };
            Employee e2 = new Employee() { Name = "Agathi", Age = 22, Country = Country.Italy, HireDate = new DateTime(2017, 11, 6), Salary = 9000, PhotoUrl = "https://yt3.ggpht.com/CN8OQyUJm7xDFoEg_HaY3AsPBgkw1eKcRbbasPIVyQPrJy0Tvn6_WJoK7rkQMX6QQDE7lNc-=s900-c-k-c0x00ffffff-no-rj" };
            Employee e3 = new Employee() { Name = "Apostolis", Age = 21, Country = Country.France, HireDate = new DateTime(2018, 5, 6), Salary = 3000, PhotoUrl = "https://i.pinimg.com/originals/03/39/8f/03398f6a50dd131b306d7209c5a9d0fa.jpg" };
            Employee e4 = new Employee() { Name = "Fanis", Age = 21, Country = Country.Greece, HireDate = new DateTime(2018, 10, 6), Salary = 40000, PhotoUrl = "https://i.pinimg.com/originals/03/39/8f/03398f6a50dd131b306d7209c5a9d0fa.jpg" };
            Employee e5 = new Employee() { Name = "Marios", Age = 21, Country = Country.Greece, HireDate = new DateTime(2018, 3, 7), Salary = 12000, PhotoUrl = "https://i.pinimg.com/originals/03/39/8f/03398f6a50dd131b306d7209c5a9d0fa.jpg" };
            Employee e6 = new Employee() { Name = "Charly", Age = 21, Country = Country.France, HireDate = new DateTime(2018, 5, 8), Salary = 7000, PhotoUrl = "https://i.pinimg.com/originals/03/39/8f/03398f6a50dd131b306d7209c5a9d0fa.jpg" };
            Employee e7 = new Employee() { Name = "Kostas", Age = 21, Country = Country.Greece, HireDate = new DateTime(2018, 5, 4), Salary = 15000, PhotoUrl = "https://i.pinimg.com/originals/03/39/8f/03398f6a50dd131b306d7209c5a9d0fa.jpg" };
            Employee e8 = new Employee() { Name = "Maria", Age = 21, Country = Country.Greece, HireDate = new DateTime(2018, 8, 3), Salary = 14000, PhotoUrl = "https://i.pinimg.com/originals/03/39/8f/03398f6a50dd131b306d7209c5a9d0fa.jpg" };
            Employee e9 = new Employee() { Name = "Ntinos", Age = 21, Country = Country.Italy, HireDate = new DateTime(2018, 5, 6), Salary = 3000, PhotoUrl = "https://i.pinimg.com/originals/03/39/8f/03398f6a50dd131b306d7209c5a9d0fa.jpg" };
            Employee e10 = new Employee() { Name = "Alexandra", Age = 21, Country = Country.Greece, HireDate = new DateTime(2018, 5, 6), Salary = 3000, PhotoUrl = "https://pbs.twimg.com/media/EYuzuGLXQAk8gP7.jpg" };
            Employee e11 = new Employee() { Name = "Spyros", Age = 21, Country = Country.Greece, HireDate = new DateTime(2018, 5, 6), Salary = 3000, PhotoUrl = "https://media.ladylike.gr/ldl-images/cameron-diaz-2.jpg" };
            Employee e12 = new Employee() { Name = "Apostolis", Age = 21, Country = Country.Greece, HireDate = new DateTime(2018, 5, 5), Salary = 21000, PhotoUrl = "https://i.pinimg.com/originals/03/39/8f/03398f6a50dd131b306d7209c5a9d0fa.jpg" };

            e1.Project = p1;
            e2.Project = p2;
            e3.Project = p3;
            e4.Project = p4;
            e5.Project = p5;
            e6.Project = p6;
            e7.Project = p7;
            e8.Project = p8;
            e9.Project = p9;
            e10.Project = p10;

            #region Seed Genres


            Genre g1 = new Genre() { Kind = "romance" };
            Genre g2 = new Genre() { Kind = "thriller" };
            Genre g3 = new Genre() { Kind = "action" };
            Genre g4 = new Genre() { Kind = "horror" };
            Genre g5 = new Genre() { Kind = "comedy" };
            context.Genres.AddOrUpdate(g => g.Kind, g1, g2, g3, g4, g5);
            context.SaveChanges();
            #endregion

            #region Seed Movies
            Movie m1 = new Movie() { Title = "Spiderman 1", Price = 20.23, Rating = 7.3, Genre= g1 };
            Movie m2 = new Movie() { Title = "Spiderman 2", Price = 40.23, Rating = 8.8, Genre= g1 };
            Movie m3 = new Movie() { Title = "Spiderman 3", Price = 60.23, Rating = 9.1, Genre=g2};
            Movie m4 = new Movie() { Title = "Breaking Bad", Price = 70.23, Rating = 9.1, Genre=g3 };
            Movie m5 = new Movie() { Title = "Prison Break", Price = 10.23, Rating = 8.4, Genre=g2 };
            Movie m6 = new Movie() { Title = "Stranger Things", Price = 100.23, Rating = 10, Genre=g1 };
            Movie m7 = new Movie() { Title = "Lacasa Depapel", Price = 123.23, Rating = 7.8, Genre=g3 };
            Movie m8 = new Movie() { Title = "Mr Robot", Price = 150.23, Rating = 7.0, Genre=g4 };
            Movie m9 = new Movie() { Title = "Office", Price = 167.23, Rating = 8.7, Genre=g5 };
            Movie m10 = new Movie() { Title = "Hangover", Price = 200.23, Rating = 9.0, Genre=g5 };
            
            context.Movies.AddOrUpdate(m => m.Title, m1, m2, m3, m4, m5, m6, m7, m8, m9, m10);
            context.SaveChanges();
            #endregion

           

            // UPSERT Operation
            context.Employees.AddOrUpdate(e => e.Name, e1, e2, e3,e4,e5,e6,e7,e8,e9,e10);
            context.SaveChanges();
            #endregion
            base.Seed(context);
        }
    }
}