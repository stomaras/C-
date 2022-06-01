using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos.Entities
{
    public class Trainer
    {

        public Trainer() { }

        public Trainer(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public int Id { get; set; } // Primary Key
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
