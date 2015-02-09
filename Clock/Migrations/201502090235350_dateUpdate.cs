namespace Clock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TimeEntry", "TimeIn", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.TimeEntry", "TimeOut", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TimeEntry", "TimeOut", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TimeEntry", "TimeIn", c => c.DateTime(nullable: false));
        }
    }
}
