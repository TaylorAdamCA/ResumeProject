using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeBuilder.Data.Migrations
{
    public partial class ResumeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Resumes",
                type: "varchar(74)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Resumes");
        }
    }
}
