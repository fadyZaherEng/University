using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using University.Models;

namespace University.Controllers
{
    public class TeacherController : Controller
    {
       UniversityDBContext db=new UniversityDBContext();
       public ActionResult GetTeachers()
       {
           List<Teacher> teachers = db.Teachers.ToList();
           Teachers teacherList = new Teachers();
           teacherList.teachers = teachers;
           return View("GetTeachers", teachers);
       }
        public ActionResult AddTeacher()
        {
            Teacher teacher = new Teacher();
            teacher.TeacherName = "Ahmed";
            teacher.TeacherNumber = 20;
            db.Teachers.Add(teacher);
            db.SaveChanges();
            return View("AddTeacher", teacher);
        }
        public ActionResult UpdateTeacher(int id)
        {
            Teacher newTeacher = new Teacher();
            newTeacher.TeacherName = "Ahmed";
            newTeacher.TeacherNumber = 20;
            Teacher teacher = db.Teachers.Find(id);
            teacher = newTeacher;
            db.SaveChanges();
            return View("UpdateTeacher", teacher);
        }
        public ActionResult DeleteTeacher(int id)
        {
            Teacher teacher = db.Teachers.Find(id);
            db.Teachers.Remove(teacher);
            db.SaveChanges();
            return View("DeleteTeacher", teacher);
        }
        public ActionResult GetTeacherDetails(int id)
        {
            Teacher teacher = db.Teachers.Find(id);
            teacher = new Teacher();
            teacher.TeacherName = "Ahmed";
            teacher.TeacherNumber = 20;
            return View("GetTeacherDetails", teacher);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}
