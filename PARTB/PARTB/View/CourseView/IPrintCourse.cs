using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.View.CourseView
{
    public interface IPrintCourse
    {
        void PrintAllCourses(List<Course> Courses);
    }
}
