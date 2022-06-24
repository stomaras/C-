namespace AuthAuthorProjects.Migrations
{
    using AuthAuthorProjects.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AuthAuthorProjects.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AuthAuthorProjects.Models.ApplicationDbContext context)
        {
            Project p1 = new Project() { Name = "C#" };
            Project p2 = new Project() { Name = "Java" };
            Project p3 = new Project() { Name = "Python" };


            if (!context.Roles.Any(x=>x.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);// You can construct roles
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };
                manager.Create(role);
            }

            if (!context.Roles.Any(x => x.Name == "Customer"))
            {
                var store = new RoleStore<IdentityRole>(context);// You can construct roles
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Customer" };
                manager.Create(role);
            }

            var PasswordHash = new PasswordHasher();// help to encrypt passwords
            if (!context.Users.Any(x=>x.UserName == "spyrostom@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    UserName = "spyrostom@gmail.com",
                    Email = "spyrostom@gmail.com",
                    PasswordHash = PasswordHash.HashPassword("Admin123!"),
                    Project = p1,
                };
                manager.Create(user);
                manager.AddToRole(user.Id, "Admin");
            }

            if (!context.Users.Any(x => x.UserName == "babis@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    UserName = "babis@gmail.com",
                    Email = "babis@gmail.com",
                    PasswordHash = PasswordHash.HashPassword("Admin123!"),
                    Project=p2,
                };
                manager.Create(user);
                manager.AddToRole(user.Id, "Customer");
            }

            if (!context.Users.Any(x => x.UserName == "agathi@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    UserName = "agathi@gmail.com",
                    Email = "agathi@gmail.com",
                    PasswordHash = PasswordHash.HashPassword("Admin123!"),
                    Project = p3,
                };
                manager.Create(user);
                manager.AddToRole(user.Id, "Customer");
            }

        }
    }
}
