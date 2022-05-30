using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolRepeatPartA.Models
{
    public class Course
    {
        public int Course_Id { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }


        // Navigation Properties

        // A Course will have many Students
        public List<Student> Students { get; set; } = new List<Student>();

        // A Course will have many Trainers 
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();

        // A Course will have many Assigments 
        public List<Assigment> Assigments { get; set; } = new List<Assigment>();

        /// <summary>
        /// This method print an object of type Trainer
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"{Course_Id,-15}{Stream,-15}{Type,-15}{Start_Date,-15}{End_Date,-15}");
        }

    }
}
