using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    /* So this interface will just have a property to store the audio file that will be run once we execute the destruction, which will be the destruction sound
     * When we implement an interface we need to implement each member of that interface.
     * 
     */
    interface IDestroyable
    {
        string DestructionSound { get; set; }

        // method to destroy an object
        void Destroy();
    }
}
