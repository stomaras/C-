using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.Initializers
{
    public class MockUpDBInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            Player p1 = new Player() { FirstName = "Lebron", LastName = "James", DateOfBirth = new DateTime(1984, 12, 30), PhotoUrl= "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bf/LeBron_James_-_51959723161_%28cropped%29.jpg/220px-LeBron_James_-_51959723161_%28cropped%29.jpg", TotalPoints= 37062, TotalAsists= 10045, StatusOfLife = true };
            Player p2 = new Player() { FirstName = "Kobe", LastName = "Bryant", DateOfBirth = new DateTime(1978, 12, 30), PhotoUrl= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRM-iO4n859oQnsBeSxGJszBZgGRg-5bisggw&usqp=CAU", TotalPoints= 33643, TotalAsists= 9000, StatusOfLife = false };
            Player p3 = new Player() { FirstName = "Michael", LastName = "Jordans", DateOfBirth = new DateTime(1963, 03, 14), PhotoUrl= "https://thumbs.dreamstime.com/b/michael-jordan-chicago-bulls-superstar-image-taken-color-slide-73861883.jpg", TotalPoints= 32292, TotalAsists= 5605, StatusOfLife = true };
            Player p4 = new Player() { FirstName = "Steph", LastName = "Curry", DateOfBirth = new DateTime(1988, 12, 30), PhotoUrl= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS9kFw0_it44banJ86mecRYGB3WqY3U9_CZ6A&usqp=CAU", TotalPoints= 37062, TotalAsists= 10045, StatusOfLife = true };

            context.Players.AddOrUpdate(p1, p2, p3, p4);
            base.Seed(context);
        }
    }
}
