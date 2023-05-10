using Microsoft.AspNetCore.Mvc;

namespace BasicASPTutorial.Controllers
{
    public class StudentController1 : Controller
    {
        public IActionResult Index()
        {
            return Content("Idadndex");
        }
    }
}
