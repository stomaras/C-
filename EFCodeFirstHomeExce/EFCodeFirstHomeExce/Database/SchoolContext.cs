using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCodeFirstHomeExce.Entities;
using System.Data.Entity;

namespace EFCodeFirstHomeExce.Database
{
    public class SchoolContext : DbContext
    {

        public SchoolContext(): base("SchoolDB")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
