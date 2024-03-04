using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using University.Models;

namespace University.Controllers
{
    public class StudentController : Controller
    {
       UniversityDBContext db = new UniversityDBContext();
        [HttpGet]
        public ActionResult GetStudents()
       {
           List<Student> students = db.Students.ToList();
           Students studentList = new Students();
           studentList.students = students;
           return View("GetStudents", studentList);
       }
        public ActionResult AddStudent()
        {
            return View("AddStudent");
        }
        [HttpPost]
        public ActionResult SubmitStudent(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
           return RedirectToAction("GetStudents");
        }
        public ActionResult UpdateStudent(int id)
        {
            Student student = db.Students.Find(id);
            DeleteStudent(id);
            db.SaveChanges();
            return View("UpdateStudent", student);
        }
        public ActionResult DeleteStudent(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("GetStudents");
        }
        public ActionResult GetStudentDetails(int id)
        {
            Student student = db.Students.Find(id);
            return View("GetStudentDetails", student);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}
