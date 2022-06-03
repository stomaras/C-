using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos.Entities
{
    public class Address
    {

        public int Id { get; set; }

        public string Name { get; set; }





        // Navigation Property
        public ICollection<House> Houses { get; set; }


    }
}
