using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.View.AssigmentView
{
    public class PrintAssigment : IPrintAssigment
    {
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
    }
}
