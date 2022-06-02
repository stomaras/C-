using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstHomeExce.Entities
{
    // Learn about how EF manages th relationship between entities (domain classes)
    [Table("StudentMaster", Schema = "Admin")]
    public class Student
    {
        [Key]
        [Column(Order = 0)]
        public int StudentID { get; set; }


        [Column("Name", Order = 1)]
        public string StudentName { get; set; }

        [Column("Dob", Order = 2 ,TypeName = "DateTime2")]
        public DateTime? DateOfBirth { get; set; }


        [Column(Order = 5)]
        public byte[] Photo { get; set; }


        [Column(Order = 4)]
        public decimal Height { get; set; }


        [Column(Order = 3)]
        public float Weight { get; set; }

        [NotMapped]
        public int Age { get; set; }


    }
}
