using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    // Step 1 Creating LEDTV
    public class LEDTV
    {
        public string Size { get; set; }
        public string Price { get; set; }
        public bool USBSupport { get; set; }

        public LEDTV(string Size, string Price, bool USBSupport)
        {
            this.Size = Size;
            this.Price = Price; 
            this.USBSupport = USBSupport;
        }

        public string GetDetails()
        {
            return $"LEDTV {{ [Size= {Size}, Price= {Price}, USBSupport= {USBSupport} }}";
        }
    }
}
