using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ptolemeos.Entities
{
    public class Animal
    {
        // (name of class) + id --> Primary Key 2nd way

        // [Key] --> Primary Key 3rd way

        [Key]
        [Column(Order =1)]
        public int AnimalId { get; set; }

        [Key]
        [Column(Order =2)]
        public string Name { get; set; }

        [NotMapped]
        public int Age { get; set; }
        // [NotMapped] --> no column in database property 


        // Attribute [Required] --> means not null property
        [Required]
        public string Country { get; set; }



        // int, bool, char, are value types must have value in database,, with ? become nullable 
        public bool? Gender { get; set; }
    }
}
