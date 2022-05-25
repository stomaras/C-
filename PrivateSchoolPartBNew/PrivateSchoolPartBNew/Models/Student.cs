using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchoolPartBNew.Interfaces;

namespace PrivateSchoolPartBNew.Models
{
    class Student : IPeople
    {
        public static int S_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int TuitionFees { get; set; }

        public Student(string FirstName, string LastName, DateTime DateOfBirth, int TuitionFees)
        {
            GenerateStudentID();
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.TuitionFees = TuitionFees;
        }

        public Student() { }

        /// <summary>
        /// This Method Checks if Year is Valid. A Year Is Valid only if is Between 1960 and 2004
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        public int CheckYearOfBirth(string year)
        {
            string ValidDay = "";
            int ReturnedValidNumber = -1;
            bool isBetween1960AndSmallerAge = false;
            bool isIntString = false;
            while (!isIntString || !isBetween1960AndSmallerAge)
            {
                Console.WriteLine($"Enter A Number between 1960 and {DateTime.Now.Year-18}:\n");
                ValidDay = Console.ReadLine();
                isIntString = ValidDay.All(char.IsDigit);
                if (isIntString)
                {
                    if (Convert.ToInt32(ValidDay) >= 1960 && (Convert.ToInt32(ValidDay) <= DateTime.Now.Year - 18))
                    {
                        isBetween1960AndSmallerAge = true;
                        ReturnedValidNumber = Convert.ToInt32(ValidDay);
                    }
                    else
                    {
                        isBetween1960AndSmallerAge = false;
                    }
                }
            }
            return ReturnedValidNumber;
        }

       

        public static void GenerateStudentID()
        {
            S_Id++;
        }

        /// <summary>
        /// Return An Object Of Type Student
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Student {{ FirstName:{FirstName}, LastName:{LastName}, DateOfBirth:{DateOfBirth}, TuitionFees{TuitionFees} }}";
        }

        

        public string CheckFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public string CheckLastName(string lastName)
        {
            throw new NotImplementedException();
        }
    }
}
