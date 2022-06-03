﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal.Entities
{
    public class Student
    {

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student() { }

       

        public Student(int id, string firstName, string lastName)
        {
            StudentId = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public Student(string firstName, string lastName)
        {
         
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
