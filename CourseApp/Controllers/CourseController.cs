using System.Linq;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController : Controller // controller gibi hareket etmesi için kullanılıyor.
    {
        //action method
        //localhost : 5000/course/index

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            
            var students = Repository.Students.Where(i => i.Confirm==true);
            return View(students);
        }

        public IActionResult Details()
        {
            // name : "Core Mvc Kursu"
            // description : "güzel bir kurs"
            // isPublished : true

            var course = new Course(); // Course modelini kullanıyoruz
            course.Name = "Core Mvc Kursu";
            course.description = "güzel bir kurs";
            course.isPublished = true;


            return View(course);

        }

        // localhost:5000/course/apply
        [HttpGet("Apply")] // bize bir kaynak getirdiği için kullanıyoruz.
        public IActionResult Apply()
        {
            return View();
        }

        // localhost:5000/course/apply method : POST
        // Name = value&Email = value&Phone=value&Confirm=value

        [HttpPost("Apply")] // iki, aynı method olduğu için biri post
        public IActionResult Apply(Student student)
        {
            // Model Binding
            // database kayıt
            if(ModelState.IsValid)
            {
            Repository.AddStudent(student);
            return View("Thanks", student); // Thanks view oluştur !
            }
            else
            {
                return View(student);

            }
        }
        
        
    }
}