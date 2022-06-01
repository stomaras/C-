using Ptolemeos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos.Views.StudentView
{
    public class InputStudent : IInputStudent
    {
        public Student GetDataForEdit()
        {
            Console.WriteLine("Give student's id to edit it");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give Student's name to edit it");
            string name = Console.ReadLine();


            Console.WriteLine("Give Student's Score");
            int score = Convert.ToInt32(Console.ReadLine());

            return new Student() { Id = id, Name = name, Score = score };
        }

        public int GetIdForDelete()
        {

            Console.WriteLine("Give student's id to delete it");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }

        public Student GetStudentData()
        {
            Console.WriteLine("Give Student's Name");
            string name = Console.ReadLine();

            Console.WriteLine("Give Student's Score");
            int score = Convert.ToInt32(Console.ReadLine());

            return new Student(name, score);
        }
    }
}
