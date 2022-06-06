﻿using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal.GeneralServices
{
    public static class GeneralPrintService
    {

        public static void StudentFirstNameCannotContainsSpecialCharsOrNums()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Student Name Cannot Contains Special Characters Or Numbers Try Again!!!\n");
            Console.ResetColor();
        }

        public static void StudentFirstNameLengthMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Student Name Must be at least 2 characters long Try Again !!!\n");
            Console.ResetColor();
        }

        public static void EnterStudentFirstName()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter Valid Student  Name\n");
            Console.ResetColor();
        }

        public static void IsNotNumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This Is Not Number Enter A Valid Id:\n");
            Console.ResetColor();
        }

        public static void StudentIdNotExistsMessage(int id)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Student with id {id} does not exists!!!");
            Console.ResetColor();
        }

        public static void SuccessDeleteMessage(Student deleteStudent)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Student {{ with id : {deleteStudent.StudentId} , with first name {deleteStudent.FirstName} , with last name {deleteStudent.LastName} deleted successfully!!!}}");
            Console.ResetColor();
        }

        
    }
}
