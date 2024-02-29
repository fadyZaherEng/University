using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace University.Models
{
    public class Teacher
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherID { get; set; }
        [Required]
        [StringLength(100)]
        public required string TeacherName { get; set; }
        public int TeacherNumber { get; set; }
    }
}
