using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCodeFirstHomeExce.Database;
using EFCodeFirstHomeExce.Entities;
namespace EFCodeFirstHomeExce
{
    internal class Program
    {
        /*
         * Let's assume that we want to create a simple application for XYZ School. Users of this school application
         * should be able to add and update students,grades,teachers, and courses information.
         * Instead of designing database tables first, let's start creating classes for our school domain, as and 
         * when needed. First, create the Student and Grade classes where every Student is associated with one Grade. This called
         * a one-to-many relationship.
         * 
         * The Code-First Approach also requires a context class which should be derived from DbContext class
         * 
         */
        static void Main(string[] args)
        {
            using(var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
