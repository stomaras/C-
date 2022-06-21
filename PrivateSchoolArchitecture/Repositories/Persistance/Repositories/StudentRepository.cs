using Entities;
using Entities.Enums;
using MyDatabase;
using Repositories.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Persistance.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {

        public StudentRepository(ApplicationDbContext context) : base(context)
        {

        }
        public IEnumerable<Student> GetStudentsByDescending()
        {
            return table.OrderBy(x => x.FirstName).ToList();
        }

        public IQueryable<IGrouping<Country, Student>> GetStudentsGroupedByCountry()
        {
            var studentsGroupByCountry = from student in table
                                         group student by student.Country into list
                                         select list;
            return studentsGroupByCountry;
        }

       
    }
}
