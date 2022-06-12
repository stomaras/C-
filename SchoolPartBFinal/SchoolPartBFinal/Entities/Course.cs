using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string  Stream { get; set; }
        public string Type { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }


        




        // Navigation Properties
        public ICollection<Student> Students { get; set; }
    }
}
