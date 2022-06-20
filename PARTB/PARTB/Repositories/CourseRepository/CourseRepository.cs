using PARTB.Database;
using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace PARTB.Repositories.CourseRepository
{
    public class CourseRepository : ICourseRepository
    {
        private ApplicationContext db;

        public CourseRepository(ApplicationContext context)
        {
            db = context;
        }

        public List<Course> GetAllCourses()
        {
            var courses = db.Courses.ToList();
            if (courses == null)
            {
                throw new NotImplementedException("Courses Does Not Exists In Database!!!");
            }
            return courses;
        }

        public List<Course> GetAllCoursesWithStudents()
        {
            var coursesWithStudents = db.Courses.Include(x => x.Students).ToList();
            if (coursesWithStudents == null)
            {
                throw new NotImplementedException("Courses join with students can not implemented In Database!!!");
            }
            return coursesWithStudents;
        }

        public List<Course> GetAllCoursesWithTrainers()
        {
            var coursesWithTrainers = db.Courses.Include(x => x.Trainers).ToList();
            if (coursesWithTrainers == null)
            {
                throw new NotImplementedException("Courses join with trainers can not implemented IIn Database!!!");
            }
            return coursesWithTrainers;
        }
    }
}
