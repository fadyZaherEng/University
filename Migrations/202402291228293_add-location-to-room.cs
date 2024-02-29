namespace University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addlocationtoroom : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "RoomLocation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rooms", "RoomLocation");
        }
    }
}
