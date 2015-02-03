namespace Phase1.Migrations
{
    using Phase1.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Phase1.Models.PhaseDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Phase1.Models.PhaseDb context)
        {
       
          Role temp =  new Role {Name = "admin"};
          User first = new User { FirstName = "Tyler", LastName = "Becker", Username = "tyler-becker", Password = "password123", Role = temp };
          new TimeEntry {UserId = first.UserId, TimeIn="10:00AM", TimeOut="7:00PM" };
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
