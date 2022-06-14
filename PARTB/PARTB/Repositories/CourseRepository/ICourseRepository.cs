using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Repositories.CourseRepository
{
    public interface ICourseRepository
    {
        List<Course> GetAllCourses();
    }
}
