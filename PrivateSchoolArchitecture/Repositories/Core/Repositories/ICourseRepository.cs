using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Core.Repositories
{
    public interface ICourseRepository : IGenericRepository<Course>
    {

        IEnumerable<Course> GetAllCoursesWithStudents();

        IEnumerable<Course> GetAllCoursesWithTrainers();

        IEnumerable<Course> GetAllCoursesWithAssigments();

    }
}
