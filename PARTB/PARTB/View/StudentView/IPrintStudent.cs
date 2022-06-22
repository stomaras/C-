using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.View.StudentView
{
    public interface IPrintStudent
    {
        void PrintStudents(List<Student> students);

        void EnterStudentDetailsToCreate(out (string firstName, string lastName, DateTime DateOfBirth, int TuitionFees) student);

        

    }
}
