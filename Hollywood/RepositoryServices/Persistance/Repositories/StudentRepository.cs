using Entities;
using MyDatabase;
using RepositoryServices.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Persistance.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {

        }

        public void DeleteAll()
        {
            var students = table;  // Attach Query

            students.RemoveRange(students);

            // throw
        }

        public void DeleteBy(Expression<Func<Student,bool>> expression)
        {
            var students = table.Where(expression).ToList();

            table.RemoveRange(students);
        }
    }
}
