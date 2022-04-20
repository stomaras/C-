using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam
{
    
    class President
    {
        private static int uid = 0;
        private int PID { get; set; }

        public string Name { get; set; }

        public Team team { get; set; }

        public President(string name, Team team)
        {
            Name = name;
            PID = uid++;
            this.team = team;
        }

        public void AddPlayerToCalendar(SelectionBasedOnCriteria selectionBasedOnCriteria, SelectionBasedOnCriteria selectionBasedOnCriteria1)
        {
            Team searchTeam = this.team;
            List<Player> players = searchTeam.players;
            Console.WriteLine($"Stars of my team");
            int i = 1;
            foreach(Player player in players)
            {
                if(selectionBasedOnCriteria(player) && selectionBasedOnCriteria1(player))
                {
                    Console.WriteLine($"Star {i} : {player.Name}");
                    i++;
                }
                
            }
        }
    }
}
