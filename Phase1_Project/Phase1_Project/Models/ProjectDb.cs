using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Phase1_Project.Models
{
    public class ProjectDb : DbContext
    {
       public DbSet<User> Users { get; set; }
       public DbSet<Role> Roles { get; set; }
       public DbSet<TimeEntry> TimeEntries { get; set; }
    }
}