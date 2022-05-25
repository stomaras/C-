using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualPartBProject.Services;

namespace IndividualPartBProject.Models
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

        public int SubmissionDay(int day)
        {
            if (day >= 1 && day <= 30)
            {
                return day;
            }
            return 1;
        }

        public int SubmissionMonth(int month)
        {
            if(month >=1 && month <= 12)
            {
                return month;
            }
            return 1;
        }

        public int SubmissionYear(int year)
        {
            return DateTime.Now.Year;
        }

        public bool CheckTitle(string title)
        {
            List<string> Assigments = RandomService.RandAssigment();
            for (int i = 0; i < Assigments.Count-1; i++)
            {
                if (Assigments[i] == title)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckDescription(string description)
        {
            List<string> AssigmentsDescription = RandomService.RandAssigmentDescription();
            for (int i = 0; i < AssigmentsDescription.Count-1; i++)
            {
                if (AssigmentsDescription[i] == description)
                {
                    return true;
                }
            }
            return false;
        }

        public static void GenerateAssigmentID()
        {
            A_Id++;
        }

        public override string ToString()
        {
            return $"Assigment {{ Title: {Title}, Description: {Description}, Submission Date Time: {SubDateTime}}}";
        }
    }
}
