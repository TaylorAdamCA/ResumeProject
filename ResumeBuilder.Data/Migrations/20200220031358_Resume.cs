using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeBuilder.Data.Migrations
{
    public partial class Resume : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResumeId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResumeId",
                table: "References",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResumeId",
                table: "Languages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResumeId",
                table: "Educations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResumeId",
                table: "CommunityServices",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(68)", nullable: false),
                    ContextId = table.Column<string>(type: "varchar(68)", nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    PersonalProfileId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resumes_PersonalProfiles_PersonalProfileId",
                        column: x => x.PersonalProfileId,
                        principalTable: "PersonalProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResumeAchievements",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(68)", nullable: false),
                    ContextId = table.Column<string>(type: "varchar(68)", nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    AchievementId = table.Column<string>(nullable: true),
                    ResumeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeAchievements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResumeAchievements_Achievements_AchievementId",
                        column: x => x.AchievementId,
                        principalTable: "Achievements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResumeAchievements_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResumeCertifications",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(68)", nullable: false),
                    ContextId = table.Column<string>(type: "varchar(68)", nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    ResumeId = table.Column<string>(nullable: true),
                    CertificationId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeCertifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResumeCertifications_Certifications_CertificationId",
                        column: x => x.CertificationId,
                        principalTable: "Certifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResumeCertifications_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResumeCommunityService",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(68)", nullable: false),
                    ContextId = table.Column<string>(type: "varchar(68)", nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    ResumeId = table.Column<string>(nullable: true),
                    CommunityServiceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeCommunityService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResumeCommunityService_CommunityServices_CommunityServiceId",
                        column: x => x.CommunityServiceId,
                        principalTable: "CommunityServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResumeCommunityService_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResumeEducation",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(68)", nullable: false),
                    ContextId = table.Column<string>(type: "varchar(68)", nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    ResumeId = table.Column<string>(nullable: true),
                    EducationId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeEducation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResumeEducation_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResumeEducation_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResumeExperience",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(68)", nullable: false),
                    ContextId = table.Column<string>(type: "varchar(68)", nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    ExperienceId = table.Column<string>(nullable: true),
                    ResumeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeExperience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResumeExperience_Experiences_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "Experiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResumeExperience_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResumeLanguage",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(68)", nullable: false),
                    ContextId = table.Column<string>(type: "varchar(68)", nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    ResumeId = table.Column<string>(nullable: true),
                    LanguageId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeLanguage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResumeLanguage_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResumeLanguage_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResumeReferences",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(68)", nullable: false),
                    ContextId = table.Column<string>(type: "varchar(68)", nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    ResumeId = table.Column<string>(nullable: true),
                    ReferenceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeReferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResumeReferences_References_ReferenceId",
                        column: x => x.ReferenceId,
                        principalTable: "References",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResumeReferences_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResumeSkills",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(68)", nullable: false),
                    ContextId = table.Column<string>(type: "varchar(68)", nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    ResumeId = table.Column<string>(nullable: true),
                    SkillId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResumeSkills_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResumeSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ResumeAchievements_AchievementId",
                table: "ResumeAchievements",
                column: "AchievementId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeAchievements_ResumeId",
                table: "ResumeAchievements",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeCertifications_CertificationId",
                table: "ResumeCertifications",
                column: "CertificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeCertifications_ResumeId",
                table: "ResumeCertifications",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeCommunityService_CommunityServiceId",
                table: "ResumeCommunityService",
                column: "CommunityServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeCommunityService_ResumeId",
                table: "ResumeCommunityService",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeEducation_EducationId",
                table: "ResumeEducation",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeEducation_ResumeId",
                table: "ResumeEducation",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeExperience_ExperienceId",
                table: "ResumeExperience",
                column: "ExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeExperience_ResumeId",
                table: "ResumeExperience",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeLanguage_LanguageId",
                table: "ResumeLanguage",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeLanguage_ResumeId",
                table: "ResumeLanguage",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeReferences_ReferenceId",
                table: "ResumeReferences",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeReferences_ResumeId",
                table: "ResumeReferences",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_PersonalProfileId",
                table: "Resumes",
                column: "PersonalProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeSkills_ResumeId",
                table: "ResumeSkills",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeSkills_SkillId",
                table: "ResumeSkills",
                column: "SkillId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "ResumeAchievements");

            migrationBuilder.DropTable(
                name: "ResumeCertifications");

            migrationBuilder.DropTable(
                name: "ResumeCommunityService");

            migrationBuilder.DropTable(
                name: "ResumeEducation");

            migrationBuilder.DropTable(
                name: "ResumeExperience");

            migrationBuilder.DropTable(
                name: "ResumeLanguage");

            migrationBuilder.DropTable(
                name: "ResumeReferences");

            migrationBuilder.DropTable(
                name: "ResumeSkills");

            migrationBuilder.DropTable(
                name: "Resumes");

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
    }
}
