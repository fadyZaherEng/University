namespace University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addstudents : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Students (StudentName, StudentNumber) VALUES ('Hassan', 1)");
            Sql("INSERT INTO Students (StudentName, StudentNumber) VALUES ('Khalid', 2)");
            Sql("INSERT INTO Students (StudentName, StudentNumber) VALUES ('Ali', 3)");
            Sql("INSERT INTO Students (StudentName, StudentNumber) VALUES ('Mona', 4)");
            Sql("INSERT INTO Students (StudentName, StudentNumber) VALUES ('Asmaa', 5)");
            Sql("INSERT INTO Students (StudentName, StudentNumber) VALUES ('Hany', 6)");
            Sql("INSERT INTO Students (StudentName, StudentNumber) VALUES ('Nada', 7)");
            Sql("INSERT INTO Students (StudentName, StudentNumber) VALUES ('Sara', 8)");
            Sql("INSERT INTO Students (StudentName, StudentNumber) VALUES ('Nada', 9)");
            Sql("INSERT INTO Students (StudentName, StudentNumber) VALUES ('Ahmed', 10)");
        }
        
        public override void Down()
        {
        }
    }
}
