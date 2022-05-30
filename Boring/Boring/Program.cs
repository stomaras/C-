using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Boring
{
    // ORM = Object Relation Mappers
    // EF6 -----> Database First : take data and convert to c# app
    //     -----> Code First : from a csharp application i create database to sq server.
    //     -----> UML TO OBJECTS
    // 
    class Program
    {
        static void Main(string[] args)
        {
            

            using (boringDataEntities db = new boringDataEntities())
            {
                

                var students = db.Student.Where(x => x.salary > 1000).OrderBy(y => y.name);

                Console.WriteLine(students);
                Console.WriteLine("-----------------------READ----------------------------------------------");

                foreach (var student in students)
                {
                    Console.WriteLine($"{student.student_id,-15}{student.name,-10}{student.salary,15}");
                }
                //Console.WriteLine("-----------------------CREATE-------------------------------------");

                //Student s = new Student() { name = "Tom", salary = 38000 }; // Synthetc data

                //db.Entry(s).State = EntityState.Added; // is going to added in sql server

                //db.SaveChanges();

                //Console.WriteLine("----------------------------DELETE---------------------------------");
                //Console.WriteLine("Choose student to delete");
                //int id = Convert.ToInt32(Console.ReadLine());
                //var student2 = db.Student.Find(id); // null or student

                //if (student2 != null)
                //{
                //    db.Entry(student2).State = EntityState.Deleted;
                //    db.SaveChanges();
                //}
                //else
                //{
                //    Console.WriteLine("Student does not exists");
                //}

                Console.WriteLine("------------------------EDIT------------------------------------------");
                Console.WriteLine("Choose Student For Edit:\n");
                int id = Convert.ToInt32(Console.ReadLine());

                var studentForEdit = db.Student.Find(id);// null or student
                if (studentForEdit == null)
                {
                    Console.WriteLine("Student does not exist!");
                    return; // in main method --> go to .exe --> 404
                }

                Console.WriteLine($"{studentForEdit.student_id,-15}{studentForEdit.name,-10}{studentForEdit.salary,15}");

                Console.WriteLine("Give new Name");
                string name = Console.ReadLine();

                Console.WriteLine("Gve you salary");
                int salary = Convert.ToInt32(Console.ReadLine());

                studentForEdit.name = name;
                studentForEdit.salary = salary;

                db.Entry(studentForEdit).State = EntityState.Modified;
                db.SaveChanges();


            }

        }
    }
}
