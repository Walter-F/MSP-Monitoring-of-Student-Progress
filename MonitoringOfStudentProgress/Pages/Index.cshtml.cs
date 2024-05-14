using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Query.Internal;
using MonitoringOfStudentProgress.Data;
using MonitoringOfStudentProgress.Models;

namespace MonitoringOfStudentProgress.Pages
{
    public class IndexModel : PageModel
    {
        public List<StudentsModel> Students = new List<StudentsModel>();
        /* private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        */

        public ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Students = _context.Students.ToList();

            /* StudentsModel studentsModel = new StudentsModel();
            studentsModel.Name = "Иванов Д.Ф.";
            studentsModel.Group = "1111";
            studentsModel.Course = "1";

            studentsModel.EstimationVisiting = 0;

            studentsModel.Estimation1Math = 0;
            studentsModel.Estimation1Rus = 0;
            studentsModel.Estimation1Phys = 0;
            studentsModel.Estimation1Chemistry = 0;
            studentsModel.Estimation1History = 0;
            studentsModel.Estimation1English = 0;

            studentsModel.Estimation2HigherMath = 0;
            studentsModel.Estimation2EngineeringGraphics = 0;
            studentsModel.Estimation2Programming = 0;
            studentsModel.Estimation2Chemistry = 0;
            studentsModel.Estimation2NTO = 0;
            studentsModel.Estimation2English = 0;

            studentsModel.Estimation3HigherMath = 0;
            studentsModel.Estimation3EngineeringGraphics = 0;
            studentsModel.Estimation3SysProgramming = 0;
            studentsModel.Estimation3PProgramming = 0;
            studentsModel.Estimation3History = 0;
            studentsModel.Estimation3English = 0;

            studentsModel.Estimation4HigherMath = 0;
            studentsModel.Estimation4InfSecurity = 0;
            studentsModel.Estimation4SysProgramming = 0;
            studentsModel.Estimation4PProgramming = 0;
            studentsModel.Estimation4NTO = 0;
            studentsModel.Estimation4English = 0;

            _context.Students.Add(studentsModel);
            _context.SaveChanges();
            */
        }
    }
}