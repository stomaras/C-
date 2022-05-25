using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchoolPartBNew.Services;

namespace PrivateSchoolPartBNew.Models
{
    class Assigment
    {
        public static int A_Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }

        public Assigment() { }

        public Assigment(string Title, string Description, DateTime SubDateTime)
        {
            GenerateAssigmentID();
            this.Title = Title;
            this.Description = Description;
            this.SubDateTime = SubDateTime;
        }

        public int CheckIfIsNumber(string num)
        {
            bool Valid = false;
            int Number;
            while (Valid == false)
            {
                string Input = Console.ReadLine();
                if (int.TryParse(Input, out Number))
                {
                    Valid = true;
                    return Number;
                }
                else
                {
                    Console.WriteLine("Not an Integer Please Try again!");
                }
            }
            return -1;
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
