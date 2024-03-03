using Microsoft.AspNetCore.Mvc;
using University.Models;

namespace University.Controllers
{
    public class CourseController : Controller
    {
        UniversityDBContext _context=new UniversityDBContext();
        [Route("Course/GetCourses")]
        public ActionResult GetCourses()
        {
            List<Course> courses = _context.Courses.ToList();
            Courses courseList = new Courses();
            courseList.courses = courses;
            ViewData["Courses"] = courseList;
            ViewBag.Courses = courseList;
         //   List<Course> coursesList = (from course in _context.Courses select course).ToList();
            return View("GetCourses",courseList);
        }
        [Route("Course/GetCourseDetails/{ID:int:range(1,10):required:regex(\\d+):maxlength(10)}")]
        public ActionResult GetCourseDetails(int ID)
        {
         Course course = _context.Courses.Find(ID);
       //  Course courseDetails=(from courseDetail in _context.Courses where courseDetail.CourseID==ID select courseDetail).FirstOrDefault();
          return View("GetCourseDetails", course);
        }
        public ActionResult AddCourse()
        {
            Course course = new Course();
            course.CourseName = "C#";
            course.CourseIsAvailable = true;
            _context.Courses.Add(course);
            _context.SaveChanges();
            return View("AddCourse",course);
        }
        public ActionResult UpdateCourse(int? ID,String Name)
        {
            if(!ID.HasValue) ID=1;
            if(String.IsNullOrWhiteSpace(Name)) Name="C#";

            Course course=new Course();
            course.CourseIsAvailable=true;
            course.CourseName="C#";
            Course courseInDatabase = _context.Courses.Find(ID);
            courseInDatabase=course;
            _context.SaveChanges();
            return View("UpdateCourse",courseInDatabase);
        }
        public ActionResult DeleteCourse(int ID)
        {
            Course courseInDatabase=new Course();
            courseInDatabase = _context.Courses.Find(ID);
         //   courseInDatabase = (from course in _context.Courses where course.CourseID == ID select course).FirstOrDefault();
            _context.Courses.Remove(courseInDatabase);    
            _context.SaveChanges();
            return View("DeleteCourse",courseInDatabase);
        }
        protected override void Dispose(bool disposing)
        {
          _context.Dispose();
        }
    }
}
