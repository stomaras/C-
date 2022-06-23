using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    // Step 4 Creating Originator
    public class Originator
    {
        /*
         * This is nothing but the Hall in our example where we need to place the led TV. Here the CreateMemento method is used to set the internal 
         * state of the memento object to led tv.The SetMemento method and you have to pass the memento object to this method and this method
         * is used to restore or rollback.From the memento object, it will get the internal state and assign that nternal state to the originator's
         * internal state.
         *  
         */

        public Chair chair;

        public Memento CreateMemento()
        {
            return new Memento(chair);
        }

        public void SetMemento(Memento memento)
        {
            chair = memento.Chair;
        }

        public string GetDetails()
        {
            return $"Originator [Chair={chair.GetDetails()}";
        }
    }
}
