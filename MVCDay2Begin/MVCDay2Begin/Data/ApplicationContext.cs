using MVCDay2Begin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDay2Begin.Data
{
    public class ApplicationContext : DbContext
    {


        public ApplicationContext() : base("Sindesmos")
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Trainer> Trainers { get; set; }
    }
}