using Entities;
using MyDatabase;
using Repositories.Core.Repostories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repositories.Persistance.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        
        public EmployeeRepository(MyDBContext context) : base(context)
        {
           
        }

        public IEnumerable<Employee> EmployeesWithProjects()
        {
            var groups = table.Include(x => x.Project).ToList();
            return groups;
        }
    }
}
