using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam
{
    class Program
    {

        public static List<Team> teams = new List<Team>();
        
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------Team Console App Begins--------------------------------");
            Player player1 = new Player("Spyros", new DateTime(1997,01,11), 13, 200);
            Player player2 = new Player("Chris", new DateTime(1997, 12, 12), 4, 23);
            Player player3 = new Player("Kostas", new DateTime(1998, 12, 11), 9, 97);
            Player player4 = new Player("Zarma", new DateTime(1998, 11, 11), 9, 9);
            Player player5 = new Player("Kwstas", new DateTime(1997, 12, 11), 9, 60);
            Team team1 = new Team("Pao");
            Team team2 = new Team("Osfp");
            team2.AddPlayer(player5);
            team2.AddPlayer(player4);
            teams.Add(team1);
            teams.Add(team2);
            team1.AddPlayer(player1);
            team1.AddPlayer(player1);
            team1.AddPlayer(player2);
            team1.AddPlayer(player3);
            team1.AddPlayer(player4);
            team1.AddPlayer(player5);
            Console.WriteLine("-----------Print Team with players--------------------");
            Console.WriteLine(team1);
            Console.WriteLine("------------------First Scorrer--------------------");
            String maxScorer = team1.FirstScorrer();
            Console.WriteLine($"First Scorrer: {maxScorer}");
            Console.WriteLine("---------------Youngest Player------------------------");
            String minName = team1.YoungerPlayer();
            Console.WriteLine($"{minName}");
            Console.WriteLine("----------------President Time-------------------------");
            President president = new President("DPG", team1);
            president.AddPlayerToCalendar();
            Console.WriteLine("--------------------Team with Best Offense-------------");
            BestOffenseTeam();

        }

        public static void BestOffenseTeam()
        {
            int maxTeamGoals = 0; ;
            string maxTeamName = "";
            for(int i=0; i<= teams.Count - 1; i++)
            {
                maxTeamName = teams[0].Name;
                maxTeamGoals = teams[0].TotalGoals();
                int currentGoals = teams[i].TotalGoals();
                if(currentGoals > maxTeamGoals)
                {
                    maxTeamName = teams[i].Name;
                    maxTeamGoals = teams[i].TotalGoals();
                }
            }
            Console.WriteLine($"Team with name : {maxTeamName} with total goals of the team : {maxTeamGoals}");
        }
    }
}
