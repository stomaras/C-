﻿using PARTB.Models;
using PARTB.Models.CustomValidations;
using PARTB.ObjectFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.View.AssigmentView
{
    public class PrintAssigment : IPrintAssigment
    {

        HelperAssigment helperAssigment = Factory.CreateHelperAssigmentObject();
        public void PrintAssigments(List<Assigment> assigments)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Assigments:\n");
            foreach (var assigment in assigments)
            {
                Console.WriteLine($"\t\tAssigment : with title {assigment.Title} , with oral mark {assigment.OralMark}, with total mark {assigment.TotalMark} , with description {assigment.Description}\n");
            }
            Console.ResetColor();
        }

        public void EnterAssigmentDetails(out (string tile, string description, DateTime subDateTime) assigment)
        {
            Console.WriteLine("Enter Assigment Details:\n");
            Console.WriteLine($"Enter Assigment Title :\n");
            string title = Console.ReadLine();
            title = helperAssigment.CheckTitle(title);

            Console.WriteLine($"Enter Assigment Description:\n");
            string description = Console.ReadLine();
            description = helperAssigment.CheckDescription(description);

            assigment = ("", "", new DateTime());
        }
    }
}
