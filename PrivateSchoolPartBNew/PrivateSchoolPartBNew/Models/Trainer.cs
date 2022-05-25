using PrivateSchoolPartBNew.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrivateSchoolPartBNew.Models
{
    class Trainer : IPeople
    {
        public static int T_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public Trainer() { }

        public Trainer(string firstName, string lastName, string subject)
        {
            GenerateTrainerID();
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        public static void GenerateTrainerID()
        {
            T_Id++;
        }

        /// <summary>
        /// This method check if course is valid,
        /// valid courses are : ['java', 'python', 'c#', 'javascript']
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public string ValidSubject(string course)
        {
            bool courseIsValid = false;

            while (!courseIsValid)
            {

                if ((course.ToLower().Equals("java")) || (course.ToLower().Equals("python")) || (course.ToLower().Equals("c#")) || (course.ToLower().Equals("javascript")))
                {
                    courseIsValid = true;

                }
                else
                {
                    courseIsValid = false;
                    Console.WriteLine("Course must be: java (or) python (or) python (or) javascript Enter a valid course:\n");
                    course = Console.ReadLine();
                    Console.WriteLine("f");
                }
            }
            return course;
        }

        /// <summary>
        /// This method check if first Name is valid
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public string CheckFirstName(string firstName)
        {
            if (firstName.Length < 2)
            {
                bool isValidFirstName = false;
                while (!isValidFirstName)
                {
                    Console.WriteLine("First Name must be at least 2 characters long!\n");
                    firstName = Console.ReadLine();
                    if (firstName.Length >= 2)
                    {
                        isValidFirstName = true;
                    }
                }
            }
            return firstName;
        }

        /// <summary>
        /// This method check if last Name is valid
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public string CheckLastName(string lastName)
        {
            Regex rgx = new Regex("[^A-Za-z]");
            bool hasSpecialChars = rgx.IsMatch(lastName);
            

            if (lastName.Length < 2 || hasSpecialChars)
            {
                bool isValidFirstName = false;
                while (!isValidFirstName || hasSpecialChars)
                {
                    Console.WriteLine("Last Name must be at least 2 characters long without contains special characters and numbers! try again:\n");
                    lastName = Console.ReadLine();
                    hasSpecialChars = rgx.IsMatch(lastName);
                    if (lastName.Length >= 2)
                    {
                        isValidFirstName = true;
                    }
                    else
                    {
                        Console.WriteLine("Last Name must be at least 2 characters long!\n");
                        isValidFirstName = false;
                    }
                    if (hasSpecialChars)
                    {
                        Console.WriteLine("Last Name Cannot Contain special characters or numbers try again!");
                    }
                    
                }
            }
            return lastName;
        }


        /// <summary>
        /// This Method Print An Object Of Class Trainer
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $" Trainer {{First Name :{FirstName}, Last Name : {LastName}, Subject {Subject}}}";
        }

        

       

        
    }
}
