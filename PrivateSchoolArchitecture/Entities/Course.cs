using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<Student>();
            this.Trainers = new HashSet<Trainer>();
            this.Assigments = new HashSet<Assigment>(); 
        }


        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }




        //Navigation Properties
        public ICollection<Student> Students { get; set; }    
        public ICollection<Trainer> Trainers { get; set; }
        public ICollection<Assigment> Assigments { get; set; }

    }
}
