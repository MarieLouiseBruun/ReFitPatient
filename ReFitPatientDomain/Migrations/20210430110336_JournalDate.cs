using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReFitPatientDomain
{
    public partial class JournalDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Journals",
                newName: "JournalID");

            migrationBuilder.AddColumn<DateTime>(
                name: "JournalDate",
                table: "Journals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JournalDate",
                table: "Journals");

            migrationBuilder.RenameColumn(
                name: "JournalID",
                table: "Journals",
                newName: "ID");
        }
    }
}
