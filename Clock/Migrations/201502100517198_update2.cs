namespace Clock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "LogFlag", c => c.Boolean(nullable: false));
            DropColumn("dbo.TimeEntry", "LogFlag");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TimeEntry", "LogFlag", c => c.Boolean(nullable: false));
            DropColumn("dbo.User", "LogFlag");
        }
    }
}
