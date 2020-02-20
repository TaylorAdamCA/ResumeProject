using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeBuilder.Data.Migrations
{
    public partial class updatedResumes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommunityServices_Resumes_ResumeId",
                table: "CommunityServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Resumes_ResumeId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Resumes_ResumeId",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_References_Resumes_ResumeId",
                table: "References");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Resumes_ResumeId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_ResumeId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_References_ResumeId",
                table: "References");

            migrationBuilder.DropIndex(
                name: "IX_Languages_ResumeId",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Educations_ResumeId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_CommunityServices_ResumeId",
                table: "CommunityServices");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "References");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "CommunityServices");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResumeId",
                table: "Skills",
                type: "varchar(68)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResumeId",
                table: "References",
                type: "varchar(68)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResumeId",
                table: "Languages",
                type: "varchar(68)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResumeId",
                table: "Educations",
                type: "varchar(68)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResumeId",
                table: "CommunityServices",
                type: "varchar(68)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ResumeId",
                table: "Skills",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_References_ResumeId",
                table: "References",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_ResumeId",
                table: "Languages",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ResumeId",
                table: "Educations",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityServices_ResumeId",
                table: "CommunityServices",
                column: "ResumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommunityServices_Resumes_ResumeId",
                table: "CommunityServices",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Resumes_ResumeId",
                table: "Educations",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Resumes_ResumeId",
                table: "Languages",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_References_Resumes_ResumeId",
                table: "References",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Resumes_ResumeId",
                table: "Skills",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
