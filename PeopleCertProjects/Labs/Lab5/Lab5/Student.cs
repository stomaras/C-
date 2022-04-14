using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{


    class Student
    {

  

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public static double Tuition { get; set; }
        public DateTime Date { get; set; }
        public string Phone { get; set; }

        public CreditCard creditCard { get; }

       

        public Student(string firstName, string lastName, int age, double height, double tuition, DateTime date, string phone, CreditCard creditCard)
        { 
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Height = height;
            Tuition = tuition;
            Date = new DateTime(2004, 11, 10);
            Phone = phone;
            this.creditCard = creditCard;

        }

        public static Student createStudent(string firstName, string lastName, int age, double height, double tuition, DateTime date, string phone, CreditCard creditCard)
        {
            return new Student(firstName, lastName, age, height, tuition, date, phone, creditCard);
        }

        

        public string GetFullName()
        {
            return (this.FirstName + " "  + this.LastName);
        }

        public void AffectConductInTuition(String conduct)
        {
            double newTuition = 0.0;
            Console.WriteLine($"Conduct tuition before raise is {Tuition}");
            if(conduct == "Poor")
            {
                newTuition = Tuition - (0.1 * Tuition);
                Tuition = newTuition;
            } else if(conduct == "Good")
            {
                newTuition = Tuition - (0.05 * Tuition);
                Tuition = newTuition;
            } else
            {
                newTuition = Tuition - (0.01 * Tuition);
                Tuition = newTuition;
            }

            Console.WriteLine($"Conduct tuition after raise  is {Tuition}");
        }

        public override string ToString()
        {
            String message = " ";
            message += "Student with full name: " + GetFullName() + " with age: " + Age + " with height: " + Height + " with tuition: " + Tuition + "\n" + " with date started the school: " + Date + " with phone: " + Phone + "\n";
            message += creditCard.ToString();
            return message;
        }

    }
}
