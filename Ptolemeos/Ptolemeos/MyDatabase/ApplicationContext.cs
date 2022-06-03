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

        public virtual DbSet<Animal> Animals { get; set; }

        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }

        public virtual DbSet<House> Houses { get; set; }

        public virtual DbSet<Address> Addresses { get; set; }
    }
}
