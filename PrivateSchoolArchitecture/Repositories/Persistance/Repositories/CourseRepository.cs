using Entities;
using MyDatabase;
using Repositories.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Persistance.Repositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(ApplicationDbContext context) : base(context)
        {

        } 

        public IEnumerable<Course> GetAllCoursesWithStudents()
        {
            var coursesWithStudents = table.Include(x => x.Students).ToList();
            if (coursesWithStudents == null)
            {
                throw new ArgumentNullException();
            }
            return coursesWithStudents;
        }
    }
}
