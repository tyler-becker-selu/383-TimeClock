using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Phase1.Models
{
    public class User
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public virtual Role Role { get; set; }
    }
    public class Role
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; }
        public string Name { get; set; }
    }
    public class TimeEntry
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int TimeEntryId { get; set; }

        [ForeignKey("User")]
        public virtual int UserId { get; set; }
        public virtual User User { get; set; }

        public string TimeIn { get; set; }
        public string TimeOut { get; set; }

    }
    public class PhaseDb : DbContext
    {
        public PhaseDb() : base("name = DefaultConnection")
        {

        }
        public DbSet <User> Users { get; set; }
        public DbSet <Role> Roles { get; set; }
        public DbSet <TimeEntry> TimeEntries { get; set; }

    }
}