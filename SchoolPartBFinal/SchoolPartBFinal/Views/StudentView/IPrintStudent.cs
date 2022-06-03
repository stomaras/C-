using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal.Views.StudentView
{
    public interface IPrintStudent
    {
        void PrintAStudent(Student student);
        void PrintStudents(List<Student> students);

        void PrintStudentSuccessUpdateMessage(string message);
        void PrintStudentFailureUpdateMessage(string message);
    }
}
