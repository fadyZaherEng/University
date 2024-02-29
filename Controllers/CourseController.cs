using Microsoft.AspNetCore.Mvc;
using University.Models;

namespace University.Controllers
{
    public class CourseController : Controller
    {
        UniversityDBContext _context=new UniversityDBContext();
        public ActionResult GetCourses()
        {

            List<Course> courses = _context.Courses.ToList();
            List<Course> coursesList = (from course in _context.Courses select course).ToList();
            return View("GetCourses", courses);
        }
        
        public ActionResult GetCourseDetails(int ID)
        {
         Course course = _context.Courses.Find(ID);
         Course courseDetails=(from courseDetail in
         _context.Courses where courseDetail.CourseID==ID select courseDetail).FirstOrDefault();
          return View("GetCourseDetails", course);
        }
        public ActionResult AddCourse()
        {
            Course course = new Course();
            course.CourseName = "C#";
            course.CourseIsAvailable = true;
            _context.Courses.Add(course);
            _context.SaveChanges();
            return View("AddCourse");
        }
    }
}
