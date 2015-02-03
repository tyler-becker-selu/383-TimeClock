using Clock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clock.DAL
{
   /* public class ClockInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ClockContext>
    {
        protected override void Seed(ClockContext context)
        {
            var Users = new List<User>
                {
                new User {Id= 1 , Username="Binay1", Firstname="Binay", Lastname="Thapa", Password="binaythapa123" , RoleId=1 } ,
                  new User {Id= 2 , Username="Binaya1", Firstname="Binaya", Lastname="Thapa", Password="12345" , RoleId=2},
                  new User {Id= 3 , Username="Micheal1", Firstname="Micheal", Lastname="Levinge", Password="ml12345" , RoleId=3},
                  new User {Id= 4 , Username="Tyler1", Firstname="Tyler", Lastname="Tyler", Password="tt12345" , RoleId=4},
                  new User {Id= 5 , Username="Shelby1", Firstname="Shelby", Lastname="Shelby", Password="ss12345" , RoleId=5}

    };
            Users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var Roles = new List<Role>
            {
                new Role {Id=1 , Name= " Binay" },
                new Role {Id=2 , Name= " Binaya"},
                new Role {Id=3 , Name= " Micheal" },
                new Role {Id=4 , Name= " Tyler" },
               new Role {Id=5 , Name= " Shelby"}
                };
            Roles.ForEach(s => context.Roles.Add(s));
            context.SaveChanges();
            var TimeEntries = new List<TimeEntry>
            {
          new TimeEntry {Id=1 , UserId=1,TimeIn= DateTime.Parse("9-00-00 am") , TimeOut=DateTime.Parse("5-00-00 pm")},
          new TimeEntry {Id= 2 , UserId=2 , TimeIn= DateTime.Parse("9-00-00 am") , TimeOut= DateTime.Parse("5-00-00 pm") },
          new TimeEntry {Id= 3 , UserId=3 , TimeIn= DateTime.Parse("9-00-00 am") , TimeOut= DateTime.Parse("5-00-00 pm")  },
          new TimeEntry { Id= 4, UserId=4 , TimeIn= DateTime.Parse("9-00-00 am") , TimeOut= DateTime.Parse("5-00-00 pm")  },
          new TimeEntry { Id=5, UserId=5 , TimeIn=DateTime.Parse("9-00-00 am") , TimeOut=DateTime.Parse("5-00-00 pm")  }
          };
            TimeEntries.ForEach(s => context.TimeEntries.Add(s));
            context.SaveChanges();
        }
    }*/
}