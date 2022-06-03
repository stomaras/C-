using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos.Entities
{
    /*
     * 
     */
     
    public class Patient
    {

        public int PatientId { get; set; }

        public string PatientName { get; set; }


        // Foreign Key --> Same name convention with Doctor class same as Primary Key of Doctor
        // int? 0..1 or int strictly 1
        public int? DoctorId { get; set; }

        // Navigation Properties

        public Doctor Doctor { get; set; }

    }
}
