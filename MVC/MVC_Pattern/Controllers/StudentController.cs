using Microsoft.AspNetCore.Mvc;

namespace MVC_Pattern.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
          List<Student> student = new List<Student>{
            new Student {Id =1, Name = "Sneha", email = "sneha@gmail.com", course = "AIML"}
            new Student {Id =1, Name = "Seema", email = "seema@gmail.com", course = "CSE"}
          }
            return View(Student);
        }
    }
}