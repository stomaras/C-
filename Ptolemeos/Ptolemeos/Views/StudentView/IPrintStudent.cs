using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ptolemeos.Entities;

namespace Ptolemeos.Views.StudentView
{
    public interface IPrintStudent
    {
        void Print(Student student);

        void PrintStudents(List<Student> students);
    }
}
