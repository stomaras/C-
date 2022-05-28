using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /*
     * For Example This Product maybe a Software , we don't mail a digital product 
     * say it's a download of some kind we wouldn't send that in the mail, we'd propably 
     * actually email that to the user
     * 
     * 
     */
    public class DigitalProductModel : IDigitalProduct
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }

        public int TotalDownloadsLeft { get; private set; } = 5;

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating emailing { Title } to { customer.EmailAddress }");
                TotalDownloadsLeft -= 1;
                if (TotalDownloadsLeft < 1)
                {
                    HasOrderBeenCompleted = true;
                    TotalDownloadsLeft = 0;
                }
            }
        }


    }
}
