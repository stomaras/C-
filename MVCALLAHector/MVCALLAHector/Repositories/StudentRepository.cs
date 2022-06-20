using MVCALLAHector.Models;
using MVCALLAHector.Models;
using MVCALLAHector.MyContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCALLAHector.Repositories
{
    public class StudentRepository
    {
        ApplicationContext db;

        public StudentRepository(ApplicationContext context)
        {
            db = context;
        }

        public List<Student> GetAll()
        {
            return db.Students.ToList();
        }
    }
}