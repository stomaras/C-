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

        void EnterCourseDetailsToCreate(out (string title, string type, DateTime start_date, DateTime end_date) course);

        void SuccessCourseCreateMessage(Course course);
    }
}
