using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /*
     * In Interface we can't have public because everyting in the Interface is public 
     * and so you must have only public things in a Contract.
     * All Products have titles , have order completion status and they have a ship item emthod
     */
    public interface IProductModel 
    {
        string Title { get; set; }

        bool HasOrderBeenCompleted { get; }

        void ShipItem(CustomerModel customer);
    }
}
