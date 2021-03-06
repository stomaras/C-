using MyDatabase;
using Repositories.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            UnitOfWork unit = new UnitOfWork(db);

            var players = unit.Players.GetAll();
            foreach (var player in players)
            {
                Console.WriteLine(player.FirstName);
            }
        }
    }
}
