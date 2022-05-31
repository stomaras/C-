using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    /*
     * A class must has only properties in order to become attributes in database
     * 
     */
    public class Student
    {
        public int Id { get; set; } // EF Understands this is Primary Key

        public string Name { get; set; }

        public int Salary { get; set; }
    }
}
