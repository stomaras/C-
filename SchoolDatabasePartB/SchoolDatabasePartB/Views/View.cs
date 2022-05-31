using SchoolDatabasePartB.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolDatabasePartB.Services;
using System.Data.Entity;

namespace SchoolDatabasePartB.Views
{
    public class View
    {

        public static void Students(DbSet<Student> Students , string message)
        {
            PrintService.PrintStudentMessage(message);
            foreach (var student in Students)
            {
                PrintService.PrintStudent(student);
            }
        }

        public static void Trainers(DbSet<Trainer> Trainers, string message)
        {
            PrintService.PrintTrainerMessage(message);
            foreach (var trainer in Trainers)
            {
                PrintService.PrintTrainer(trainer);
            }
        }

        public static void Assigments(DbSet<Assigment> Assigments, string message)
        {
            PrintService.PrintAssigmentMessage(message);
            foreach (var assigment in Assigments)
            {
                PrintService.PrintAssigment(assigment);
            }
        }
    }
}
