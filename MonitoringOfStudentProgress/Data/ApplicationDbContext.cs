using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MonitoringOfStudentProgress.Models;

namespace MonitoringOfStudentProgress.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<StudentsModel> Students { get; set; }
        public DbSet<TeachersModel> Teachers { get; set; }
        public DbSet<AdministratorsModel> Administrators { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }
    }
}