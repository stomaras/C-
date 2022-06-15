using MVCALLAHector.Models;
using MVCALLAHector.Models.Enums;
using MVCALLAHector.Models.ViewModels;
using MVCALLAHector.MyContext;
using MVCALLAHector.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCALLAHector.Controllers
{
    public class HomeController : Controller
    {

        

       
        //localhost:32231/home/index
        public ActionResult Index()
        {
            Student s1 = new Student() { Name = "Hector", Age = 34 };
            Student s2 = new Student() { Name = "Marios", Age = 27 };
            Student s3 = new Student() { Name = "Damianos", Age = 15 };

            Employee e1 = new Employee() { Name = "Tom", Age = 24, Country = Country.Greece, HireDate = new DateTime(2015, 5, 6), Salary = 12000, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjI0MTg3MzI0M15BMl5BanBnXkFtZTcwMzQyODU2Mw@@._V1_UY1200_CR130,0,630,1200_AL_.jpg" };
            Employee e2 = new Employee() { Name = "Agathi", Age = 22, Country = Country.Italy, HireDate = new DateTime(2017, 11, 6), Salary = 9000, PhotoUrl = "https://yt3.ggpht.com/CN8OQyUJm7xDFoEg_HaY3AsPBgkw1eKcRbbasPIVyQPrJy0Tvn6_WJoK7rkQMX6QQDE7lNc-=s900-c-k-c0x00ffffff-no-rj" };
            Employee e3 = new Employee() { Name = "Apostolis", Age = 21, Country = Country.France, HireDate = new DateTime(2018, 5, 6), Salary = 3000, PhotoUrl = "https://i.pinimg.com/originals/03/39/8f/03398f6a50dd131b306d7209c5a9d0fa.jpg" };

            List<Employee> employees = new List<Employee>() { e1, e2, e3 };
            List<Student> students = new List<Student>() { s1, s2, s3 };

            // ViewModel
            Baroufa baroufa = new Baroufa()
            {
                Title = "Baroufa Object",
                Employees = employees,
                Students = students,
                EmployeesCount = employees.Count()
            };
            return View(baroufa);
        }
        // if is true that HomeController is in distraction mode... please destroy 
        // the ApplicationContext
        

    }
}