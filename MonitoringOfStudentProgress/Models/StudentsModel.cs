using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MonitoringOfStudentProgress.Data;
using System;
using System.Linq;

namespace MonitoringOfStudentProgress.Models
{
    public class StudentsModel  
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public string Course { get; set; }
        public int EstimationVisiting { get; set; }

        public int Estimation1Math { get; set; }
        public int Estimation1Rus { get; set; }
        public int Estimation1Phys { get; set; }
        public int Estimation1Chemistry { get; set; }
        public int Estimation1History { get; set; }
        public int Estimation1English { get; set; }

        public int Estimation2HigherMath { get; set; }
        public int Estimation2EngineeringGraphics { get; set; }
        public int Estimation2Programming { get; set; }
        public int Estimation2Chemistry { get; set; }
        public int Estimation2NTO { get; set; }
        public int Estimation2English { get; set; }

        public int Estimation3HigherMath { get; set; }
        public int Estimation3EngineeringGraphics { get; set; }
        public int Estimation3SysProgramming { get; set; }
        public int Estimation3PProgramming { get; set; }
        public int Estimation3History { get; set; }
        public int Estimation3English { get; set; }

        public int Estimation4HigherMath { get; set; }
        public int Estimation4InfSecurity { get; set; }
        public int Estimation4SysProgramming { get; set; }
        public int Estimation4PProgramming { get; set; }
        public int Estimation4NTO { get; set; }
        public int Estimation4English { get; set; }
    }
}
