using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos.Entities
{
    public class Student
    {

        public Student() { }
        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public int Id { get; set; }// Primary Key

        public string Name { get; set; }

        public int Score { get; set; }
    }
}
