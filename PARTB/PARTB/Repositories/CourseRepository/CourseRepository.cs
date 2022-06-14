using PARTB.Database;
using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Repositories.CourseRepository
{
    public class CourseRepository : ICourseRepository
    {
        private ApplicationContext db = new ApplicationContext();

        public CourseRepository(ApplicationContext context)
        {
            db = context;
        }

        public List<Course> GetAllCourses()
        {
            var courses = db.Courses.ToList();
            return courses;
        }
    }
}
