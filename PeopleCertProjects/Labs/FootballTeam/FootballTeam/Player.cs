using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam
{
    class Player
    {
        private static int uid = 0;
        private int id;
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Goals { get; set; }
        public int TotalGoals { get; set; }

        public Player(string name, DateTime dateOfBirth, int goals, int totalGoals)
        {
            this.id = uid++;
            Name = name;
            DateOfBirth = dateOfBirth;
            Goals = goals;
            TotalGoals = totalGoals;
        }

        public override string ToString()
        {
            return $"Player with :\n\t Name - {Name}\n\t Date of birth - {DateOfBirth}\n\t Goals - {Goals}\n\t TotalGoals - {TotalGoals}";
        }
    }
}
