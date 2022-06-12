using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Models
{
    public class Course
    {

        public Course()
        {
            this.Assigments = new HashSet<Assigment>();
            this.Trainers = new HashSet<Trainer>();
            this.Students = new HashSet<Student>();
        }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }



        // Navigation Properties
        public ICollection<Student> Students { get; set; }

        public ICollection<Trainer> Trainers { get; set; }
        public ICollection<Assigment> Assigments { get; set; }
    }
}
