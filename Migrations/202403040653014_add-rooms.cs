namespace University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrooms : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO Rooms (RoomName,RoomSize, RoomIsAvailable, RoomLocation) VALUES ('Room 1',1, 1, 'A')");
            Sql(@"INSERT INTO Rooms (RoomName,RoomSize, RoomIsAvailable, RoomLocation) VALUES ('Room 2',2, 1, 'B')");
            Sql(@"INSERT INTO Rooms (RoomName,RoomSize, RoomIsAvailable, RoomLocation) VALUES ('Room 3',3, 1, 'C')");
            Sql(@"INSERT INTO Rooms (RoomName,RoomSize, RoomIsAvailable, RoomLocation) VALUES ('Room 4',4, 1, 'D')");
            Sql(@"INSERT INTO Rooms (RoomName,RoomSize, RoomIsAvailable, RoomLocation) VALUES ('Room 5',5, 1, 'E')");
            Sql(@"INSERT INTO Rooms (RoomName,RoomSize, RoomIsAvailable, RoomLocation) VALUES ('Room 6',6, 1, 'F')");
            Sql(@"INSERT INTO Rooms (RoomName,RoomSize, RoomIsAvailable, RoomLocation) VALUES ('Room 7',7, 1, 'G')");
            Sql(@"INSERT INTO Rooms (RoomName,RoomSize, RoomIsAvailable, RoomLocation) VALUES ('Room 8',8, 1, 'H')");
            Sql(@"INSERT INTO Rooms (RoomName,RoomSize, RoomIsAvailable, RoomLocation) VALUES ('Room 9',9, 1, 'I')");
            Sql(@"INSERT INTO Rooms (RoomName,RoomSize, RoomIsAvailable, RoomLocation) VALUES ('Room 10',10, 1, 'J')");
        }
        
        public override void Down()
        {
        }
    }
}
