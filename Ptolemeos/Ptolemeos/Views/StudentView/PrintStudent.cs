using Ptolemeos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos.Views.StudentView
{
    public class PrintStudent : IPrintStudent
    {
        public void Print(Student student)
        {
            Console.WriteLine("Print Student to Console");
            throw new NotImplementedException();
        }

        public void PrintStudents(List<Student> studebnts)
        {
            Console.WriteLine("Print All Students to Console");
            throw new NotImplementedException();
        }
    }
}
