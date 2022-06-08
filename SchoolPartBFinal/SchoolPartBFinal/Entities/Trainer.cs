using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal.Entities
{
    public class Trainer
    {
        
        public int Id { get; set; }

        [Required]
        [Display(Name ="First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        public string Subject { get; set; }

        public Trainer() { }

        public Trainer(int id, string firstName, string lastName, string subject)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        public Trainer(string firstName, string lastName, string subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }
    }
}
