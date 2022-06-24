using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthAuthorProjects.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Project()
        {
            Users = new HashSet<ApplicationUser>();
        }

        // Navigation Properties
        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}