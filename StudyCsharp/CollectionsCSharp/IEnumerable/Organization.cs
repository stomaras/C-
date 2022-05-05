using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerables
{
    class Organization: IEnumerable
    {
        List<Employee> Emps = new List<Employee>();
        public void Add(Employee Emp)
        {
            Emps.Add(Emp);
        }

    }
}
