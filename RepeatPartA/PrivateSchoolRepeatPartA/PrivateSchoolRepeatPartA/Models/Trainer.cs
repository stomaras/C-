using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolRepeatPartA.Models
{
    public class Trainer
    {
        public int Trainer_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        // Navigation Properties

        // A trainer can teach multiple courses
        public List<Course> Courses { get; set; }



        /// <summary>
        /// This method print an object of type Trainer
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"{Trainer_Id,-15}{FirstName,-15}{LastName,-15}{Subject,-15}");
        }
    }
}
