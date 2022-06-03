using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ptolemeos.Entities
{
    public class House
    {
        public int HouseId { get; set; }

        public string Name { get; set; }

        // Foreign Keys
        [ForeignKey("Doctor")]
        public int GiatrosId { get; set; }

        // Convention Which class do you want to be foreign key -> Address + Id
        public int AddressId { get; set; }


        // Navigation Properties
        public Doctor Doctor { get; set; }

        public Address Address { get; set; }
    }
}
