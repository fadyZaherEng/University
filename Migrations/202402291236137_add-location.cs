namespace University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addlocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "Location", c => c.String());
            DropColumn("dbo.Rooms", "RoomLocation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rooms", "RoomLocation", c => c.String());
            DropColumn("dbo.Rooms", "Location");
        }
    }
}
