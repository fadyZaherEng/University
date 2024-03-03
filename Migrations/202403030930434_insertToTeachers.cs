namespace University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertToTeachers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Teachers (TeacherName, TeacherNumber) VALUES ('Hassan', 1)");
            Sql("INSERT INTO Teachers (TeacherName, TeacherNumber) VALUES ('Khalid', 2)");
            Sql("INSERT INTO Teachers (TeacherName, TeacherNumber) VALUES ('Ali', 3)");
            Sql("INSERT INTO Teachers (TeacherName, TeacherNumber) VALUES ('Mona', 4)");
            Sql("INSERT INTO Teachers (TeacherName, TeacherNumber) VALUES ('Asmaa', 5)");
            Sql("INSERT INTO Teachers (TeacherName, TeacherNumber) VALUES ('Hany', 6)");
            Sql("INSERT INTO Teachers (TeacherName, TeacherNumber) VALUES ('Nada', 7)");
            Sql("INSERT INTO Teachers (TeacherName, TeacherNumber) VALUES ('Sara', 8)");
            Sql("INSERT INTO Teachers (TeacherName, TeacherNumber) VALUES ('Ahmed', 9)");
            Sql("INSERT INTO Teachers (TeacherName, TeacherNumber) VALUES ('Mahmoud', 10)");
        }
        
        public override void Down()
        {
        }
    }
}
