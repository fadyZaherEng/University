namespace University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "CourseIsAvailable", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "CourseIsAvailable", c => c.Int(nullable: false));
        }
    }
}
