using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Country
    {
        private int IDCountry { get; set; }
        public string Name { get; set; }

        public List<Student> students;

        public Country(string Name)
        {
            this.Name = Name;
            this.students = new List<Student>();
            GetIDCountry();
        }

        public void addStudent(Student student)
        {
            
            students.Add(student);
            Console.WriteLine($"student {student.FirstName} added successfully");
        }

        public void GetIDCountry()
        {
            IDCountry++;
        }

        public override string ToString()
        {
            String studentsPerCountry = "";
            
            Console.WriteLine($"Country {this.Name} with below mentioned students: \n");
            for(int i=0; i <= students.Count-1; i++)
            {
                studentsPerCountry += students[i].ToString() + "\n";
            }
            return studentsPerCountry;
        }
    }
}
