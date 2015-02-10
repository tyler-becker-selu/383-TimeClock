namespace Clock.Migrations
{
    using Clock.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Helpers;

    internal sealed class Configuration : DbMigrationsConfiguration<Clock.DAL.ClockContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Clock.DAL.ClockContext context)
        {
            var Roles = new List<Role>
            {
                new Role {Id=1 , Name= "Admin" },
                new Role {Id=2 , Name= "User" }
                };

            Roles.ForEach(s => context.Roles.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

            var HashPassword = Crypto.HashPassword("selu2014");
            var Users = new List<User>
                {
                new User {Id= 1 , Username="admin", Firstname="selu", Lastname="selu", Password=HashPassword , RoleId=1 },
                new User {Id= 2 , Username="test", Firstname="test", Lastname="test", Password=HashPassword , RoleId=1 }

             };
            Users.ForEach(s => context.Users.AddOrUpdate(s));
            context.SaveChanges();
          var TimeEntries = new List<TimeEntry>
            {
               new TimeEntry { Id=1, UserId=1 , TimeIn=DateTime.Parse("2002-09-24-06:00").ToLocalTime() , TimeOut=DateTime.Parse("2002-09-24-08:00").ToLocalTime()  },
               new TimeEntry { Id=2, UserId=1 , TimeIn=DateTime.Parse("2012-09-24-06:00").ToLocalTime() , TimeOut=DateTime.Parse("2012-09-24-10:00").ToLocalTime()  }
            };
            TimeEntries.ForEach(s => context.TimeEntries.AddOrUpdate(s));
            context.SaveChanges();

            
         
        }
    }
}