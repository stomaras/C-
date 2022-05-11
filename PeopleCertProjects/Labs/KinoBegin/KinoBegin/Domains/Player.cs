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
        private int _PID;

        public int PID
        {
            get { return _PID; }
            set { _PID = value; }
        }

        private string _fullName;

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }


        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private bool _kinoBonus;

        public bool KinoBonus
        {
            get { return _kinoBonus; }
            set { _kinoBonus = value; }
        }


        private Ticket _ticket;

        public Ticket Ticket
        {
            get { return _ticket; }
            set { _ticket = value; }
        }


        public Player(Ticket ticket)
        {
            FullName = RandomService.RandName();
            Age = RandomService.Age();
            Ticket = ticket;
            PlayerService playerService = new PlayerService();
            KinoBonus = playerService.PlayWithKinoBonus();
            PID++;
        }

        public override string ToString()
        {
            string message = "";
            if (KinoBonus)
            {
                message = "Play with Kino Bonus";
            }
            else
            {
                message = "Don't play with Kino Bonus";
            }
            string s = $"Player {PID} {{ with full name : {FullName}, with age : {Age}, {message} ,with Tickets: \n{Ticket}}}";
            return s;

        }



    }
}
