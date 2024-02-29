using System.Data.Entity;

namespace University.Models
{
    public class UniversityDBContext : DbContext
    {
        const string connectionString = "Data Source=Jesus;Initial Catalog=University;Integrated Security=True;";
        public UniversityDBContext() : base(connectionString)
        {

        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
