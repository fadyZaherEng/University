namespace University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class roomAvailble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rooms", "RoomIsAvailable", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rooms", "RoomIsAvailable", c => c.Int(nullable: false));
        }
    }
}
