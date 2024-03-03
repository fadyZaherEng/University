using Microsoft.AspNetCore.Mvc;
using University.Models;

namespace University.Controllers
{
    public class RoomController : Controller
    {
        UniversityDBContext db=new UniversityDBContext();
        public ActionResult GetRooms()
        {
            List<Room> rooms = db.Rooms.ToList();
            Rooms roomlist = new Rooms();
            roomlist.rooms = rooms;
            return View("GetRooms",roomlist);
        }
        public ActionResult GetRoomDetails(int id)
        { 
          Room room = db.Rooms.Find(id);
          return View("GetRoomDetails",room);
        }
        public ActionResult AddRoom()
        {
            Room room = new Room();
            room.RoomName = "C#";
            room.RoomIsAvailable = true;
            db.Rooms.Add(room);
            db.SaveChanges();
            return View("AddRoom",room);
        }
        public ActionResult UpdateRoom(int id)
        {
            Room newRoom=new Room();
            newRoom.RoomName = "C#";
            newRoom.RoomIsAvailable = true;
            newRoom.RoomLocation = "Cairo";
            Room room = db.Rooms.Find(id);
            room = newRoom;
            db.SaveChanges();
            return View("UpdateRoom",room);
        }
        public ActionResult DeleteRoom(int id)
        {
            Room room = db.Rooms.Find(id);
            db.Rooms.Remove(room);
            db.SaveChanges();
            return View("DeleteRoom",room);
        }

    }
}
