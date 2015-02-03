namespace Clock.Migrations
{
    using Clock.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

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
                new Role {Id=1 , Name= " Binay" },
                new Role {Id=2 , Name= " Binaya"},
                new Role {Id=3 , Name= " Micheal" },
                new Role {Id=4 , Name= " Tyler" },
               new Role {Id=5 , Name= " Shelby"}
                };

            Roles.ForEach(s => context.Roles.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

            var Users = new List<User>
                {
                new User {Id= 1 , Username="Binay1", Firstname="Binay", Lastname="Thapa", Password="binaythapa123" , RoleId=1 } ,
                  new User {Id= 2 , Username="Binaya1", Firstname="Binaya", Lastname="Thapa", Password="12345" , RoleId=2},
                  new User {Id= 3 , Username="Micheal1", Firstname="Micheal", Lastname="Levinge", Password="ml12345" , RoleId=3},
                  new User {Id= 4 , Username="Tyler1", Firstname="Tyler", Lastname="Tyler", Password="tt12345" , RoleId=4},
                  new User {Id= 5 , Username="Shelby1", Firstname="Shelby", Lastname="Shelby", Password="ss12345" , RoleId=5}

    };
            Users.ForEach(s => context.Users.AddOrUpdate(s));
            context.SaveChanges();

      //      Users.ForEach(s => context.Users.Add(s));
        //    context.SaveChanges();
           //DateTime convertedTime = new DateTime(DateTime.Parse(dateStr).Ticks), DateTimeKind.Utc);
          var TimeEntries = new List<TimeEntry>
            {
         // new TimeEntry {
           //   UserId= context.Users.Single(u => u.Lastname=="Thapa").Id,
               new TimeEntry { Id=1, UserId=1 , TimeIn=DateTime.Parse("2002-09-24-06:00").ToLocalTime() , TimeOut=DateTime.Parse("2002-09-24-08:00").ToLocalTime()  },
               new TimeEntry { Id=2, UserId=2 , TimeIn=DateTime.Parse("2012-09-24-06:00").ToLocalTime() , TimeOut=DateTime.Parse("2012-09-24-10:00").ToLocalTime()  }
            };
            TimeEntries.ForEach(s => context.TimeEntries.AddOrUpdate(s));
            context.SaveChanges();
            // RoleId= context.Roles.Single(r=> r.Id==1).Id,

            
         
        }
    }
}