using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoBegin.Services;
namespace KinoBegin.Domains
{
    class Player
    {
        private int _pid;

        public int PID
        {
            get { return _pid; }
            set { _pid = value; }
        }


        private string _FullName;

        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public List<Ticket> Tickets { get; private set; }
        public Player()
        {
            Tickets = new List<Ticket>();
            FullName = RandomService.RandName();
            Age = RandomService.Age();
        }

        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
