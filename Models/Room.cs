using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace University.Models
{
    public class Room 
    {
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         public int RoomID { get; set; }
         [Required]
         [StringLength(100)]
         public  string RoomName { get; set; }
         public int RoomIsAvailable { get; set; }
         public int RoomSize { get; set;}
         public String RoomLocation { get; set; }
    }
}
