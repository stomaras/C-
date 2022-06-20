﻿using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("Sindesmos")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Assigment> Assigments { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
