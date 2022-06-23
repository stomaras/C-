using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Chair
    {
        public int Height { get; set; }
        public double Price { get; set; }

        public Chair(int Height, double Price)
        {
            this.Height = Height;
            this.Price = Price;
        }

        public string GetDetails()
        {
            return $"Chair {{ Height {Height}, Price {Price} }}";
        }
    }
}
