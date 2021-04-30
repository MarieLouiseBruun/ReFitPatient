using Microsoft.EntityFrameworkCore.Migrations;

namespace ReFitPatientData
{
    public partial class InitialDBCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    SSN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.SSN);
                });

            migrationBuilder.CreateTable(
                name: "ExercisePackages",
                columns: table => new
                {
                    ExercisePackageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientSSN = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExercisePackages", x => x.ExercisePackageID);
                    table.ForeignKey(
                        name: "FK_ExercisePackages_Patients_PatientSSN",
                        column: x => x.PatientSSN,
                        principalTable: "Patients",
                        principalColumn: "SSN",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Journals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JournalType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PainScale = table.Column<double>(type: "float", nullable: false),
                    BendAngle = table.Column<double>(type: "float", nullable: false),
                    Medicine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientSSN = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journals", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Journals_Patients_PatientSSN",
                        column: x => x.PatientSSN,
                        principalTable: "Patients",
                        principalColumn: "SSN",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    ExerciseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Repetitions = table.Column<int>(type: "int", nullable: false),
                    ExercisePackageID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.ExerciseID);
                    table.ForeignKey(
                        name: "FK_Exercises_ExercisePackages_ExercisePackageID",
                        column: x => x.ExercisePackageID,
                        principalTable: "ExercisePackages",
                        principalColumn: "ExercisePackageID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExercisePackages_PatientSSN",
                table: "ExercisePackages",
                column: "PatientSSN");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ExercisePackageID",
                table: "Exercises",
                column: "ExercisePackageID");

            migrationBuilder.CreateIndex(
                name: "IX_Journals_PatientSSN",
                table: "Journals",
                column: "PatientSSN");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Journals");

            migrationBuilder.DropTable(
                name: "ExercisePackages");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
