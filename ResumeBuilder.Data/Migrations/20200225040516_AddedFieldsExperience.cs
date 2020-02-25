using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeBuilder.Data.Migrations
{
    public partial class AddedFieldsExperience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Experiences");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Experiences",
                type: "varchar(128)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Experiences",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Experiences",
                type: "varchar(128)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Experiences");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
