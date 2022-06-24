using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MovieUserOrders
    {
        [Key]
        [Column(Order=1)]
        public int MovieId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string UserId { get; set; }

        public DateTime OrderCompleted { get; set; }
    }
}
