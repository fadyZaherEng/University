using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using University.Models;

namespace University.Controllers
{
    public class StudentController : Controller
    {
       UniversityDBContext db = new UniversityDBContext();
       public ActionResult GetStudents()
       {
           List<Student> students = db.Students.ToList();
           Students studentList = new Students();
           studentList.students = students;
           return View("GetStudents", studentList);
       }
        public ActionResult AddStudent()
        {
            //Student student = new Student();
            //student.StudentName = "Ahmed";
            //student.StudentNumber = 20;
            //db.Students.Add(student);
            //db.SaveChanges();
            return View("AddStudent");
        }
        public ActionResult SubmitStudent(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            Students students = new Students();
            students.students = db.Students.ToList();
            return View("GetStudents", students);
        }
        public ActionResult UpdateStudent(int id)
        {
            Student newStudent = new Student();
            newStudent.StudentName = "Ahmed";
            newStudent.StudentNumber = 20;
            Student student = db.Students.Find(id);
            student = newStudent;
            db.SaveChanges();
            return View("UpdateStudent", student);
        }
        public ActionResult DeleteStudent(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return View("DeleteStudent", student);
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
