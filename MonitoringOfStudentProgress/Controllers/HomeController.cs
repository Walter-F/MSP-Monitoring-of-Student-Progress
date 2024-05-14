using Microsoft.AspNetCore.Mvc;

namespace MonitoringOfStudentProgress.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DoWorkOne1()
        {
            ViewBag.Message = "Список студентов обновлён!";
            return View();
        }

        [HttpPost]
        public IActionResult DoWorkOne()
        {
            ViewBag.Message = "Список студентов обновлён!";
            return View();
        }
    }
}
