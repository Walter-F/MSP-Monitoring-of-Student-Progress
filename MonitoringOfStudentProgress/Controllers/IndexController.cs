using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MonitoringOfStudentProgress.Data;
using MonitoringOfStudentProgress.Models;

namespace MonitoringOfStudentProgress.Controllers
{
    public class IndexController : Controller
    {
        private ApplicationDbContext _context;

        public List<StudentsModel> Students = new List<StudentsModel>();

        public IndexController(ApplicationDbContext context)
        {
            _context = context;
        }
    
        public IActionResult Index()
        {
            Students = _context.Students.ToList();
            return View(Students);  
        }
        public IActionResult ShowCourseFirst()
        {
            Students = _context.Students.ToList();
            return View(Students);
        }

        public IActionResult ShowCourseSecond()
        {
            Students = _context.Students.ToList();
            return View(Students);
        }
        public IActionResult ShowCourseThird()
        {
            Students = _context.Students.ToList();
            return View(Students);
        }
        public IActionResult ShowCourseFourth()
        {
            Students = _context.Students.ToList();
            return View(Students);
        }
    }
}
