using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeBuilder.Data.Migrations
{
    public partial class JoinTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResumeCommunityService_CommunityServices_CommunityServiceId",
                table: "ResumeCommunityService");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeCommunityService_Resumes_ResumeId",
                table: "ResumeCommunityService");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeExperience_Experiences_ExperienceId",
                table: "ResumeExperience");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeExperience_Resumes_ResumeId",
                table: "ResumeExperience");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeLanguage_Languages_LanguageId",
                table: "ResumeLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeLanguage_Resumes_ResumeId",
                table: "ResumeLanguage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResumeLanguage",
                table: "ResumeLanguage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResumeExperience",
                table: "ResumeExperience");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResumeCommunityService",
                table: "ResumeCommunityService");

            migrationBuilder.RenameTable(
                name: "ResumeLanguage",
                newName: "ResumeLanguages");

            migrationBuilder.RenameTable(
                name: "ResumeExperience",
                newName: "ResumeExperiences");

            migrationBuilder.RenameTable(
                name: "ResumeCommunityService",
                newName: "ResumeCommunityServices");

            migrationBuilder.RenameIndex(
                name: "IX_ResumeLanguage_ResumeId",
                table: "ResumeLanguages",
                newName: "IX_ResumeLanguages_ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_ResumeLanguage_LanguageId",
                table: "ResumeLanguages",
                newName: "IX_ResumeLanguages_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_ResumeExperience_ResumeId",
                table: "ResumeExperiences",
                newName: "IX_ResumeExperiences_ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_ResumeExperience_ExperienceId",
                table: "ResumeExperiences",
                newName: "IX_ResumeExperiences_ExperienceId");

            migrationBuilder.RenameIndex(
                name: "IX_ResumeCommunityService_ResumeId",
                table: "ResumeCommunityServices",
                newName: "IX_ResumeCommunityServices_ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_ResumeCommunityService_CommunityServiceId",
                table: "ResumeCommunityServices",
                newName: "IX_ResumeCommunityServices_CommunityServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResumeLanguages",
                table: "ResumeLanguages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResumeExperiences",
                table: "ResumeExperiences",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResumeCommunityServices",
                table: "ResumeCommunityServices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeCommunityServices_CommunityServices_CommunityServiceId",
                table: "ResumeCommunityServices",
                column: "CommunityServiceId",
                principalTable: "CommunityServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeCommunityServices_Resumes_ResumeId",
                table: "ResumeCommunityServices",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeExperiences_Experiences_ExperienceId",
                table: "ResumeExperiences",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeExperiences_Resumes_ResumeId",
                table: "ResumeExperiences",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeLanguages_Languages_LanguageId",
                table: "ResumeLanguages",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeLanguages_Resumes_ResumeId",
                table: "ResumeLanguages",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResumeCommunityServices_CommunityServices_CommunityServiceId",
                table: "ResumeCommunityServices");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeCommunityServices_Resumes_ResumeId",
                table: "ResumeCommunityServices");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeExperiences_Experiences_ExperienceId",
                table: "ResumeExperiences");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeExperiences_Resumes_ResumeId",
                table: "ResumeExperiences");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeLanguages_Languages_LanguageId",
                table: "ResumeLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeLanguages_Resumes_ResumeId",
                table: "ResumeLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResumeLanguages",
                table: "ResumeLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResumeExperiences",
                table: "ResumeExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResumeCommunityServices",
                table: "ResumeCommunityServices");

            migrationBuilder.RenameTable(
                name: "ResumeLanguages",
                newName: "ResumeLanguage");

            migrationBuilder.RenameTable(
                name: "ResumeExperiences",
                newName: "ResumeExperience");

            migrationBuilder.RenameTable(
                name: "ResumeCommunityServices",
                newName: "ResumeCommunityService");

            migrationBuilder.RenameIndex(
                name: "IX_ResumeLanguages_ResumeId",
                table: "ResumeLanguage",
                newName: "IX_ResumeLanguage_ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_ResumeLanguages_LanguageId",
                table: "ResumeLanguage",
                newName: "IX_ResumeLanguage_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_ResumeExperiences_ResumeId",
                table: "ResumeExperience",
                newName: "IX_ResumeExperience_ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_ResumeExperiences_ExperienceId",
                table: "ResumeExperience",
                newName: "IX_ResumeExperience_ExperienceId");

            migrationBuilder.RenameIndex(
                name: "IX_ResumeCommunityServices_ResumeId",
                table: "ResumeCommunityService",
                newName: "IX_ResumeCommunityService_ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_ResumeCommunityServices_CommunityServiceId",
                table: "ResumeCommunityService",
                newName: "IX_ResumeCommunityService_CommunityServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResumeLanguage",
                table: "ResumeLanguage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResumeExperience",
                table: "ResumeExperience",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResumeCommunityService",
                table: "ResumeCommunityService",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeCommunityService_CommunityServices_CommunityServiceId",
                table: "ResumeCommunityService",
                column: "CommunityServiceId",
                principalTable: "CommunityServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeCommunityService_Resumes_ResumeId",
                table: "ResumeCommunityService",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeExperience_Experiences_ExperienceId",
                table: "ResumeExperience",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeExperience_Resumes_ResumeId",
                table: "ResumeExperience",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeLanguage_Languages_LanguageId",
                table: "ResumeLanguage",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeLanguage_Resumes_ResumeId",
                table: "ResumeLanguage",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
