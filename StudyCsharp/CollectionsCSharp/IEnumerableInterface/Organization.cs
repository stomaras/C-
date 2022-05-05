using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableInterface
{
    /*
     * I want to make Organization works like collection,
     * all collection classes inherits from IEnumerable so implements a method called GetEnumerator
     * that is a reason why forEach Loop Working , in this case in Organization Class forEach Loop does not work from by default 
     * but if i inherit from IEnumerable everything is going to be okay
     * 
     * 
     */
    class Organization : IEnumerable
    {
        List<Employee> Emps = new List<Employee>();
        public void Add(Employee Emp)
        {
            Emps.Add(Emp);
        }

        public IEnumerator GetEnumerator()
        {
            return Emps.GetEnumerator();
        }
    }
}
