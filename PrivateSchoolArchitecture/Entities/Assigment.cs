using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Assigment
    {

        public Assigment()
        {
            this.Courses = new HashSet<Course>();
            this.Students = new HashSet<Student>();
        }
        public int AssigmentId { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }

        //Navigation Properties
        public ICollection<Course> Courses { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
