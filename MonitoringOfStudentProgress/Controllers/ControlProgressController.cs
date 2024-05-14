using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MonitoringOfStudentProgress.Data;
using MonitoringOfStudentProgress.Models;


namespace MonitoringOfStudentProgress.Controllers
{
    public class ControlProgressController : Controller
    {
        SignInManager<IdentityUser> SignInManager;
        UserManager<IdentityUser> UserManager;

        private readonly ApplicationDbContext _context;

        public ControlProgressController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public JsonResult AjaxMethod()
        {
            return Json(true);
        }

        // GET: ControlProgress
        public IActionResult Main()
        {
            return View();
                        
        }

        // GET: ControlProgress/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var studentsModel = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentsModel == null)
            {
                return NotFound();
            }

            return View(studentsModel);
        }

        // GET: ControlProgress/Create
        public IActionResult Complete()
        {
            return View();
        }

        public IActionResult Failed()
        {
            return View();
        }

        // POST: ControlProgress/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Group,Course,EstimationVisiting,Estimation1Math,Estimation1Rus,Estimation1Phys,Estimation1Chemistry,Estimation1History,Estimation1English,Estimation2HigherMath,Estimation2EngineeringGraphics,Estimation2Programming,Estimation2Chemistry,Estimation2NTO,Estimation2English,Estimation3HigherMath,Estimation3EngineeringGraphics,Estimation3SysProgramming,Estimation3PProgramming,Estimation3History,Estimation3English,Estimation4HigherMath,Estimation4InfSecurity,Estimation4SysProgramming,Estimation4PProgramming,Estimation4NTO,Estimation4English")] StudentsModel studentsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentsModel);
        }



        [HttpPost]
        public async Task<IActionResult> Main(string FIO, string Subject, string newEstimation)
        {
            if(FIO == null || Subject == null || newEstimation == null)
            {
                return RedirectToAction(nameof(Main));
            }

            StudentsModel? currentStudent = _context.Students.FirstOrDefault(x => x.Name == FIO);
            TeachersModel? currentTeacher = _context.Teachers.FirstOrDefault(x => x.Mail == User.Identity.Name);
            string currrentSpecialization = currentTeacher.Specialization;

            if (Subject == "Посещение")
            {
                currentStudent.EstimationVisiting = Int32.Parse(newEstimation);
            }
            else if(Subject == "Математика" && currrentSpecialization == "Математика")
            {
                currentStudent.Estimation1Math = Int32.Parse(newEstimation);
            }
            else if (Subject == "Русский" && currrentSpecialization == "Русский")
            {
                currentStudent.Estimation1Rus = Int32.Parse(newEstimation);
            }
            else if (Subject == "Физика" && currrentSpecialization == "Физика")
            {
                currentStudent.Estimation1Phys = Int32.Parse(newEstimation);
            }
            else if (Subject == "Химия" && currrentSpecialization == "Химия")
            {
                currentStudent.Estimation1Chemistry = Int32.Parse(newEstimation);
            }
            else if (Subject == "История" && currrentSpecialization == "История")
            {
                currentStudent.Estimation1History = Int32.Parse(newEstimation);
            }
            else if (Subject == "Английский" && currrentSpecialization == "Английский")
            {
                currentStudent.Estimation1English = Int32.Parse(newEstimation);
            }
            else if (Subject == "Высшая математика" && currrentSpecialization == "\"Высшая математика")
            {
                currentStudent.Estimation2HigherMath = Int32.Parse(newEstimation);
            }
            else if (Subject == "Инженерная графика" && currrentSpecialization == "Инженерная графика")
            {
                currentStudent.Estimation2EngineeringGraphics = Int32.Parse(newEstimation);
            }
            else if (Subject == "Программирование" && currrentSpecialization == "Программирование")
            {
                currentStudent.Estimation2Programming = Int32.Parse(newEstimation);
            }
            else if (Subject == "Химия" && currrentSpecialization == "Химия")
            {
                currentStudent.Estimation2Chemistry = Int32.Parse(newEstimation);
            }
            else if (Subject == "Наладчик технологического оборудования" && currrentSpecialization == "Наладчик технологического оборудования")
            {
                currentStudent.Estimation2NTO = Int32.Parse(newEstimation);
            }
            else if (Subject == "Английский" && currrentSpecialization == "Английский")
            {
                currentStudent.Estimation2English = Int32.Parse(newEstimation);
            }
            else if (Subject == "Высшая математика" && currrentSpecialization == "Высшая математика")
            {
                currentStudent.Estimation3HigherMath = Int32.Parse(newEstimation);
            }
            else if (Subject == "Инженерная графика" && currrentSpecialization == "Инженерная графика")
            {
                currentStudent.Estimation3EngineeringGraphics = Int32.Parse(newEstimation);
            }
            else if (Subject == "Системеное программирование" && currrentSpecialization == "Системеное программирование")
            {
                currentStudent.Estimation3SysProgramming = Int32.Parse(newEstimation);
            }
            else if (Subject == "Прикладное программирование" && currrentSpecialization == "Прикладное программирование")
            {
                currentStudent.Estimation3PProgramming = Int32.Parse(newEstimation);
            }
            else if (Subject == "История" && currrentSpecialization == "История")
            {
                currentStudent.Estimation3History = Int32.Parse(newEstimation);
            }
            else if (Subject == "Английский" && currrentSpecialization == "Английский")
            {
                currentStudent.Estimation3English = Int32.Parse(newEstimation);
            }
            else if (Subject == "Высшая математика" && currrentSpecialization == "Высшая математика")
            {
                currentStudent.Estimation1Math = Int32.Parse(newEstimation);
            }
            else if (Subject == "Информационная безопасность" && currrentSpecialization == "Информационная безопасность")
            {
                currentStudent.Estimation1Math = Int32.Parse(newEstimation);
            }
            else if (Subject == "Системное программирование" && currrentSpecialization == "Системное программирование")
            {
                currentStudent.Estimation1Math = Int32.Parse(newEstimation);
            }
            else if (Subject == "Прикладное программирование" && currrentSpecialization == "Прикладное программирование")
            {
                currentStudent.Estimation1Math = Int32.Parse(newEstimation);
            }
            else if (Subject == "Наладчик технологического оборудования" && currrentSpecialization == "Наладчик технологического оборудования")
            {
                currentStudent.Estimation1Math = Int32.Parse(newEstimation);
            }
            else if (Subject == "Английский" && currrentSpecialization == "Английский")
            {
                currentStudent.Estimation1Math = Int32.Parse(newEstimation);
            } 
            else
            {
                return RedirectToAction(nameof(Failed));
            }


            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(currentStudent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentsModelExists(currentStudent.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Complete));
            }
            else
            {
                return RedirectToAction(nameof(Failed));
            }
        }
 

        // GET: ControlProgress/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var studentsModel = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentsModel == null)
            {
                return NotFound();
            }

            return View(studentsModel);
        }

        // POST: ControlProgress/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Students == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Students'  is null.");
            }
            var studentsModel = await _context.Students.FindAsync(id);
            if (studentsModel != null)
            {
                _context.Students.Remove(studentsModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentsModelExists(int id)
        {
          return (_context.Students?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
