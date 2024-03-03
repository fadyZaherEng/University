using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace University.Models
{
    public class Course 
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseID{ get; set; }
        [Required]
        [StringLength(100)]
        public  string CourseName { get; set; }
        public bool CourseIsAvailable{ get; set; }
    }
}
