using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    // Step 3 : Creating Caretaker
    public class Caretaker
    {
        // This is nothing but the storeroom which is used to hold the led TVs. The caretaker is used to maintain the memeno objects. This class is having
        // wo methods. The AddMemento method is used to add memento into the ledTVList properties and the GetMemento method is used to return the memento object
        
        private List<Memento> chairList = new List<Memento>();

        public void AddMemento(Memento m)
        {
            chairList.Add(m);
            Console.WriteLine("Chair snapshots Mainained by CareTaker:" + m.GetDetails());
        }

        public Memento GetMemento(int index)
        {
            return chairList[index];
        }
    }
}
