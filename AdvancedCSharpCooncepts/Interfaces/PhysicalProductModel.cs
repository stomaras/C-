using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    /*
     * Each Physical Product has a Title , it has an bool said HasOrderBeenCompleted
     * and has a method called ShipItem, which takes a CustomerModel
     * Physical Product is something that has to be shipped to the user.
     * 
     */
    public class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping { Title } to { customer.FirstName } in { customer.City }");
                HasOrderBeenCompleted = true;
            }
        }

    }
}
