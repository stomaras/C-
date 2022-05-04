using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPart2
{
    // List<TValue>
    // Dictionary<TKey,TValue>
    // In case of a generic collection the type of values we want to store under
    // the collections need not be pre-defined typed only like int, float, char, string, bool e.t.c
    // but it can be some user-defined type also.
    // Customer : 
    //  -Custid
    //  -Name
    //  -City
    //  -Balance
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> dt = new Dictionary<string, object>();
            dt.Add("Eid", 1010);
            dt.Add("Ename", "scott");
            dt.Add("Tom", "tomfv");

            foreach(string key in dt.Keys)
            {
                Console.WriteLine(key + ": " + dt[key]);
            }

            List<Customer> customers = new List<Customer>();

            Customer c1 = new Customer
            {
                Custid = 101,
                Name = "Chris",
                City = "Athens",
                Balance = 100.56
            };

            Customer c2 = new Customer
            {
                Custid = 102,
                Name = "Scott",
                City = "Athens",
                Balance = 100.56
            };

            Customer c3 = new Customer
            {
                Custid = 103,
                Name = "Spyros",
                City = "Athens",
                Balance = 100.56
            };

            Customer c4 = new Customer
            {
                Custid = 104,
                Name = "Tom",
                City = "Athens",
                Balance = 100.56
            };
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Custid + " " + customer.Name + " " + customer.City + " " + customer.Balance);
            }
        }
    }
}
