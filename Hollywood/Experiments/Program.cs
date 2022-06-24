using Entities;
using MyDatabase;
using RepositoryServices;
using RepositoryServices.Core;
using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            UnitOfWork hollywoodUnit = new UnitOfWork(db);

            var groups = hollywoodUnit.Actors.GetActorsGroupedByCountry();

            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key,15}: {group.Count()}");
            }

            //Console.WriteLine("-------------");

            //foreach (var group in groups)
            //{
            //    Console.WriteLine($"{group.Key,15}");

            //    foreach (var actor in group)
            //    {
            //        Console.WriteLine($"{"",15}:{actor.FirstName + " " + actor.LastName}");
            //    }

            //}
        }
    }
}
