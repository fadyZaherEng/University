using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace University.Models
{
    public class Student 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }
        [Required]
        [StringLength(100)]
        public  string StudentName { get; set; }
        public int StudentNumber { get; set; }
    }
}
