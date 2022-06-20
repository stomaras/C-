using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.View.Per
{
    public interface IPrintPer
    {
        void PrintAllStudentsPerCourse(List<Course> Courses);

        void PrintAllTrainersPerCourse(List<Course> Courses);
    }
}
