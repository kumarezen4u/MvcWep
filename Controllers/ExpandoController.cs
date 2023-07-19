using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebMvc.Controllers
{
    public class ExpandoController : Controller
    {
        // GET: Expando
        public ActionResult Index()
        {
            //multiple models in single view in mvc Using ExpandoObject
            ViewBag.Message = "Welcome to my demo!";
            dynamic mymodel = new ExpandoObject();
            mymodel.Teachers = GetTeachers();
            mymodel.Students = GetStudents();

            dynamic college = new ExpandoObject();
            college.Name = "SRM University";        
            college.courses = new string[] { "BE Computer Science", "BE Civil Engineering", "BE Machanical Engineering", "BE Electronic Engineering", "BE Chemical Engineering" };
            college.Address = new ExpandoObject();
            college.Address1 = "#48 Muthamiz Street";
            college.Address2 = "GST Road, Kattankulathur";
            college.pincode = 603302;
            mymodel.College = college;

            //multiple models in single view in mvc Using ViewData
            ViewData["Teachers"] = GetTeachers();
            ViewData["Students"] = GetStudents();
            TempData["Courses"] = GetCourse();
            //multiple models in single view in mvc - Using  ViewData
            ViewBag.Teachers = GetTeachers();
            ViewBag.Students = GetStudents();
            return View(mymodel);
        }

        public ActionResult indexTuple()
        {
            //multiple models in single view in mvc - Using  Tuple
            var tupleModel = new Tuple<List<Teacher>, List<Student>>(GetTeachers(), GetStudents());

            return View(tupleModel);
        }

        public ActionResult IndexviewModel() 
        {
            ViewModel objViewModel = new ViewModel();
            objViewModel.Teachers = GetTeachers();
            objViewModel.Students = GetStudents();
            return View(objViewModel);
        }


        

        private List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher { TeacherId = 1, Code = "TT", Name = "Tejas Trivedi" });
            teachers.Add(new Teacher { TeacherId = 2, Code = "JT", Name = "Jignesh Trivedi" });
            teachers.Add(new Teacher { TeacherId = 3, Code = "RT", Name = "Rakesh Trivedi" });
            return teachers;
        }

        private List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { StudentId = 1, Code = "L0001", Name = "Amit Gupta", EnrollmentNo = "201404150001" });
            students.Add(new Student { StudentId = 2, Code = "L0002", Name = "Chetan Gujjar", EnrollmentNo = "201404150002" });
            students.Add(new Student { StudentId = 3, Code = "L0003", Name = "Bhavin Patel", EnrollmentNo = "201404150003" });
            return students;
        }

        public List<Course> GetCourse()
        {
            List<Course> lstCourses = new List<Course>()
            {
                new Course(){CourseId= 1 , CourseName="Physices"},
                 new Course(){CourseId= 2 , CourseName="Chemistery"},
                   new Course(){CourseId= 3 , CourseName="Matchematices"},
            };
            lstCourses.Add(new Course() { CourseId = 4, CourseName = "Accountancy" });

            Course objcourse = new Course();
            objcourse.CourseId = 5;
            objcourse.CourseName = "Commerces";
            lstCourses.Add(objcourse);

            return lstCourses;
        }

    }

    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string EnrollmentNo { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }  
    }

    public class ViewModel
    {
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}