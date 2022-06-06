using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPartBFinal.Entities
{
    public class Student
    {

        public int StudentId { get; set; }

        [Required]
        [Display(Name = " First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }


        [Required]
        [Display(Name = " Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }


        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }


        [Required]
        public decimal TuitionFees { get; set; }


        public Student() { }

       

        public Student(int id, string firstName, string lastName)
        {
            StudentId = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public Student(string firstName, string lastName)
        {
         
            FirstName = firstName;
            LastName = lastName;
        }

        public Student(string firstName, string lastName, DateTime birthDate, int TuitonFees)
        {
         
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            TuitionFees = TuitonFees;
        }

    }
}
