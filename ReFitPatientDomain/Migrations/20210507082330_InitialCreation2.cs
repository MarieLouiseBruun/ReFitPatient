using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReFitPatientDomain.Migrations
{
    public partial class InitialCreation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    SSN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Completed = table.Column<bool>(type: "bit", nullable: false),
                    PatientSSN = table.Column<string>(type: "nvarchar(10)", nullable: true)
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
                name: "JournalCollections",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientSSN = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalCollections", x => x.ID);
                    table.ForeignKey(
                        name: "FK_JournalCollections_Patients_PatientSSN",
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
                    ExerciseLink = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Sets = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Repetitions = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Hide = table.Column<bool>(type: "bit", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Journals",
                columns: table => new
                {
                    JournalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JournalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JournalType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PainScale = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    BendAngle = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    Medicine = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    GeneralComment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    JournalCollectionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journals", x => x.JournalID);
                    table.ForeignKey(
                        name: "FK_Journals_JournalCollections_JournalCollectionID",
                        column: x => x.JournalCollectionID,
                        principalTable: "JournalCollections",
                        principalColumn: "ID",
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
                name: "IX_JournalCollections_PatientSSN",
                table: "JournalCollections",
                column: "PatientSSN");

            migrationBuilder.CreateIndex(
                name: "IX_Journals_JournalCollectionID",
                table: "Journals",
                column: "JournalCollectionID");
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
                name: "JournalCollections");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
