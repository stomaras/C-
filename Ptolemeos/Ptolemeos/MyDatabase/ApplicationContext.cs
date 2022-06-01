using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Ptolemeos.Entities;
namespace Ptolemeos.MyDatabase
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
