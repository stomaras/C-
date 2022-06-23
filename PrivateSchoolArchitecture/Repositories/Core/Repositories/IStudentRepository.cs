using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Core.Repositories
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
         IEnumerable<Student> GetStudentsByDescending();
         IQueryable<IGrouping<Country, Student>> GetStudentsGroupedByCountry();

         IEnumerable<Student> GetStudentsByDateOfBirth();

         int SumOfTuitionFees(IEnumerable<Student> students);

         IEnumerable<Student> GetAllTuitionFees();

        DateTime MinAgeOfSudents(IEnumerable<Student> students);

     
    }
}
