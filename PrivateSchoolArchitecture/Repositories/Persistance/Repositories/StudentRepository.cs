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

        public IEnumerable<Student> GetStudentsByDateOfBirth()
        {
            return table.OrderByDescending(x => x.DateOfBirth).ToList();
        }

        public IQueryable<IGrouping<Country, Student>> GetStudentsGroupedByCountry()
        {
            var studentsGroupByCountry = from student in table
                                         group student by student.Country into list
                                         select list;
            return studentsGroupByCountry;
        }

        public int SumOfTuitionFees(IEnumerable<Student> students)
        {

            int sumOfTuitionFees = 0;
            foreach (var stu in students)
            {
                sumOfTuitionFees += stu.TuitionFees;
            }
            if (sumOfTuitionFees == 0)
            {
                throw new ArgumentNullException();
            }

            return sumOfTuitionFees;
        }

        public IEnumerable<Student> GetAllTuitionFees()
        {
            throw new NotImplementedException();
        }

        public DateTime MinAgeOfSudents(IEnumerable<Student> students)
        {
            List<DateTime> dateOfBirth = new List<DateTime>();

            foreach (var stu in students)
            {
                dateOfBirth.Add(stu.DateOfBirth);
            }

            DateTime minAge = (from num in dateOfBirth
                          select num).Max();
            return minAge;
        }
    }
}
