using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace CodeFirst
{
    public class MyContext : DbContext
    {
        // connection string name--> Sindesmos same
        public MyContext() : base("Sindesmos")
        {
            
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
    }
}
