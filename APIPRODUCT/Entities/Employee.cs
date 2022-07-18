using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee : SuperMarket
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumOfKids { get; set; }
        public int AnnualIncome { get; set; }

        //Foreign Keys
        public int? ShopId { get; set; }


        //Navigation Properties
        public Shop Shop { get; set; }
    }
}
