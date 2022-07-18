using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Player : NBA
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhotoUrl { get; set; }
        public int TotalPoints { get; set; }
        public int TotalAsists { get; set; }
        public bool StatusOfLife { get; set; }
    }
}
