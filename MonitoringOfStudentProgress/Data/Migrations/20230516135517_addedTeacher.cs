using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonitoringOfStudentProgress.Data.Migrations
{
    public partial class addedTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrators",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Course = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstimationVisiting = table.Column<int>(type: "int", nullable: false),
                    Estimation1Math = table.Column<int>(type: "int", nullable: false),
                    Estimation1Rus = table.Column<int>(type: "int", nullable: false),
                    Estimation1Phys = table.Column<int>(type: "int", nullable: false),
                    Estimation1Chemistry = table.Column<int>(type: "int", nullable: false),
                    Estimation1History = table.Column<int>(type: "int", nullable: false),
                    Estimation1English = table.Column<int>(type: "int", nullable: false),
                    Estimation2HigherMath = table.Column<int>(type: "int", nullable: false),
                    Estimation2EngineeringGraphics = table.Column<int>(type: "int", nullable: false),
                    Estimation2Programming = table.Column<int>(type: "int", nullable: false),
                    Estimation2Chemistry = table.Column<int>(type: "int", nullable: false),
                    Estimation2NTO = table.Column<int>(type: "int", nullable: false),
                    Estimation2English = table.Column<int>(type: "int", nullable: false),
                    Estimation3HigherMath = table.Column<int>(type: "int", nullable: false),
                    Estimation3EngineeringGraphics = table.Column<int>(type: "int", nullable: false),
                    Estimation3SysProgramming = table.Column<int>(type: "int", nullable: false),
                    Estimation3PProgramming = table.Column<int>(type: "int", nullable: false),
                    Estimation3History = table.Column<int>(type: "int", nullable: false),
                    Estimation3English = table.Column<int>(type: "int", nullable: false),
                    Estimation4HigherMath = table.Column<int>(type: "int", nullable: false),
                    Estimation4InfSecurity = table.Column<int>(type: "int", nullable: false),
                    Estimation4SysProgramming = table.Column<int>(type: "int", nullable: false),
                    Estimation4PProgramming = table.Column<int>(type: "int", nullable: false),
                    Estimation4NTO = table.Column<int>(type: "int", nullable: false),
                    Estimation4English = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrators");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
