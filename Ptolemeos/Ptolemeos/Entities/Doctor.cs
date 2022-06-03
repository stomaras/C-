using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos.Entities
{
    /*
     * A Doctor has many Patient
     * 
     * 
     * 
     */
    public class Doctor
    {

        public int DoctorId { get; set; }

        public string DoctorName { get; set; }


        // may virtual may not is acceptable depends on needs each time


        //Navigation Properties
        public ICollection<Patient> Patients { get; set; }

        public virtual ICollection<House> Houses { get; set; }
    }
}
