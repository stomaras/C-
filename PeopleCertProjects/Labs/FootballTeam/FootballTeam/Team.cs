using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam
{
    class Team
    {
        private static int uid = 0;
        private string _firstScorrer = "";
        private int TID { get; set; }
        public String Name { get; set; }
        public List<Player> players { get; set; }

        public string FirstScorrer
        {
            get
            {
                int maxScore = 0;
                string _firstScorrer = "";
                for (int i = 0; i <= this.players.Count - 1; i++)
                {
                    if (this.players[i].TotalGoals > maxScore)
                    {
                        maxScore = this.players[i].TotalGoals;
                        _firstScorrer = this.players[i].Name;
                    }
                }
                return $"First scorrer of {this.Name} is : {_firstScorrer}";
            }
        }

        public Team (string name)
        {
            TID = uid++;
            Name = name;
            players = new List<Player>();
        }

        public bool AddPlayer(Player player)
        {
            if(players.Count <=6)
            {
                for (int i = 0; i <= players.Count - 1; i++)
                {
                    String name = players[i].Name;
                    if (player.Name.Equals(name))
                    {
                        Console.WriteLine($"player with name {player.Name} already exists!!!!");
                        return false;
                    }
                }
                Console.WriteLine($"player with name {player.Name} added successfully!!!");
                this.players.Add(player);
                return true;
            }
            else
            {
                Console.WriteLine("A team can't have more than 7 players ");
                return false;
            }
            
        }

        public int TotalGoals()
        {
            int sumOfGoals = 0;
            for(int i=0; i<= players.Count -1; i++)
            {
                sumOfGoals += players[i].TotalGoals;
            }
            return sumOfGoals;
        }

        public String YoungerPlayer()
        {
            DateTime minDate = new DateTime(1900,01,01);
            String minName = "";
            for(int i=0; i <= this.players.Count - 1; i++)
            {
                int res = DateTime.Compare(minDate, this.players[i].DateOfBirth);
                if(res < 0)
                {
                    minDate = this.players[i].DateOfBirth;
                    minName = this.players[i].Name;
                } 
            }
            return $"Youngest player of the team {this.Name} is : {minName}";
        }

        public override string ToString()
        {
            String s = "";
            s = $"Team with name: {Name} has following players: \n";
            for(int i=0; i<= this.players.Count -1; i++)
            {
                Player newPlayer = players[i];
                s = s + $"\n\tPlayer {i + 1} , name {newPlayer.Name}, date of birth {newPlayer.DateOfBirth}, season goals {newPlayer.Goals}, all time goals {newPlayer.TotalGoals}, all time assists {newPlayer.Assists}, all time red cards {newPlayer.RedCards}";

            }
            return s;
        }
    }
}



/*
        * public String FirstScorrer()
       {
           int maxScore = 0;
           string maxName = "";
           for(int i=0; i<= this.players.Count - 1; i++)
           {
               if(this.players[i].TotalGoals > maxScore)
               {
                   maxScore = this.players[i].TotalGoals;
                   maxName = this.players[i].Name;
               }
           }
           return $"First scorrer of {this.Name} is : {maxName}";
       }
        * 
        */
