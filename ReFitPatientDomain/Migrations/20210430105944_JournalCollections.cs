using Microsoft.EntityFrameworkCore.Migrations;

namespace ReFitPatientDomain
{
    public partial class JournalCollections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Journals_Patients_PatientSSN",
                table: "Journals");

            migrationBuilder.DropIndex(
                name: "IX_Journals_PatientSSN",
                table: "Journals");

            migrationBuilder.DropColumn(
                name: "PatientSSN",
                table: "Journals");

            migrationBuilder.AddColumn<int>(
                name: "JournalCollectionID",
                table: "Journals",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Journals_JournalCollectionID",
                table: "Journals",
                column: "JournalCollectionID");

            migrationBuilder.CreateIndex(
                name: "IX_JournalCollections_PatientSSN",
                table: "JournalCollections",
                column: "PatientSSN");

            migrationBuilder.AddForeignKey(
                name: "FK_Journals_JournalCollections_JournalCollectionID",
                table: "Journals",
                column: "JournalCollectionID",
                principalTable: "JournalCollections",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Journals_JournalCollections_JournalCollectionID",
                table: "Journals");

            migrationBuilder.DropTable(
                name: "JournalCollections");

            migrationBuilder.DropIndex(
                name: "IX_Journals_JournalCollectionID",
                table: "Journals");

            migrationBuilder.DropColumn(
                name: "JournalCollectionID",
                table: "Journals");

            migrationBuilder.AddColumn<string>(
                name: "PatientSSN",
                table: "Journals",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Journals_PatientSSN",
                table: "Journals",
                column: "PatientSSN");

            migrationBuilder.AddForeignKey(
                name: "FK_Journals_Patients_PatientSSN",
                table: "Journals",
                column: "PatientSSN",
                principalTable: "Patients",
                principalColumn: "SSN",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
