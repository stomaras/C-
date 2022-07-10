﻿using Entities;
using MyDatabase.Initializers;
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
        public ApplicationDbContext():base("Sindesmos")
        {
            Database.SetInitializer<ApplicationDbContext>(new MockUpDBInitializer());
            Database.Initialize(false);
        }

        public DbSet<Player> Players { get; set; }
    }
}
