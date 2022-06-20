using MyDatabase;
using RepositoryServices;
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

            MovieRepository movieRepository = new MovieRepository(db);

            foreach (var movie in movieRepository.GetAll())
            {
                Console.WriteLine(movie.Title);
            }
        }
    }
}
