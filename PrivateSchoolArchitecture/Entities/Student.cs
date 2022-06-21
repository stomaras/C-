using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Student : SchoolEntity
    {

        public Student()
        {
            
            this.Assigments = new HashSet<Assigment>();
        }
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }
        public Country Country { get; set; }

        // Foreign Keys
        public int CourseId { get; set; }

        // Navigation Properties
        public Course Course { get; set; }

        
        public ICollection<Assigment> Assigments { get; set; }
    }
}
