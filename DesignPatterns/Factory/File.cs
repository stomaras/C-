using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class File
    {
        private List<Items> _Itemss = new List<Items>();
        // Constructor calls abstract factory method
        public File()
        {
            this.CreateItemss();
        }
        public List<Items> Itemss
        {
            get { return _Itemss; }
        }
        // Factory Method
        public abstract void CreateItemss();
    }
}
