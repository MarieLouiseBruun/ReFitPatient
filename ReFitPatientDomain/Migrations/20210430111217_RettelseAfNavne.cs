using Microsoft.EntityFrameworkCore.Migrations;

namespace ReFitPatientDomain
{
    public partial class RettelseAfNavne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PackageName",
                table: "ExercisePackages",
                newName: "Name");

            migrationBuilder.AddColumn<bool>(
                name: "Hide",
                table: "Exercises",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "ExercisePackages",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hide",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "Completed",
                table: "ExercisePackages");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ExercisePackages",
                newName: "PackageName");
        }
    }
}
