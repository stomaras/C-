using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Memento
    {
        // Step 2: Creating Memeno

        // The Memento Object is used to store the internal state of he originator. The originator has LED TV as an internal state
        // and we are initializing that LedV internal state using the constructor

        
        public Chair Chair { get; set; }

        public Memento(Chair chair)
        {
            this.Chair = chair;
        }

        public string GetDetails()
        {
            return "Memento [Chair=" + Chair.GetDetails() + "]";
        }

    }
}
