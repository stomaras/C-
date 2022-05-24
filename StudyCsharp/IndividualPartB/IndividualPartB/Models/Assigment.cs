using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Models
{
    public class Assigment
    {
        public static int A_Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        
        public Assigment(string Title, string Description, DateTime SubDateTime)
        {
            GenerateAssigmentID();
            this.Title = Title;
            this.Description = Description;
            this.SubDateTime = SubDateTime;
        }

        public static void GenerateAssigmentID()
        {
            A_Id++;
        }

        public override string ToString()
        {
            return $"Assigment {{ Title {Title}, Description {Description}, Submission Date Time {SubDateTime}}}";
        }
    }
}
