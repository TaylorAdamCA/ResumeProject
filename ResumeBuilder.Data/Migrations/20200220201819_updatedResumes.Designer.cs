﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResumeBuilder.Data;

namespace ResumeBuilder.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200220201819_updatedResumes")]
    partial class updatedResumes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.Achievement", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.Certification", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("CertificateAuthority")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateReceived")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Certifications");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.CommunityService", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.ToTable("CommunityServices");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.Education", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.Experience", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("AdditionalInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.Language", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Proficiency")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.Link", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.Property<string>("PersonalProfileId")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalProfileId");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.PersonalProfile", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("varchar(74)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("varchar(2)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.HasKey("Id");

                    b.ToTable("PersonalProfiles");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.Reference", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionInCompany")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.ToTable("References");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.Resume", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(74)");

                    b.Property<string>("PersonalProfileId")
                        .HasColumnType("varchar(68)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalProfileId");

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.ResumeAchievements", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("AchievementId")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResumeId")
                        .HasColumnType("varchar(68)");

                    b.HasKey("Id");

                    b.HasIndex("AchievementId");

                    b.HasIndex("ResumeId");

                    b.ToTable("ResumeAchievements");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.ResumeCertifications", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("CertificationId")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResumeId")
                        .HasColumnType("varchar(68)");

                    b.HasKey("Id");

                    b.HasIndex("CertificationId");

                    b.HasIndex("ResumeId");

                    b.ToTable("ResumeCertifications");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.ResumeCommunityService", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("CommunityServiceId")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResumeId")
                        .HasColumnType("varchar(68)");

                    b.HasKey("Id");

                    b.HasIndex("CommunityServiceId");

                    b.HasIndex("ResumeId");

                    b.ToTable("ResumeCommunityServices");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.ResumeEducation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("EducationId")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ResumeId")
                        .HasColumnType("varchar(68)");

                    b.HasKey("Id");

                    b.HasIndex("EducationId");

                    b.HasIndex("ResumeId");

                    b.ToTable("ResumeEducation");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.ResumeExperience", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExperienceId")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ResumeId")
                        .HasColumnType("varchar(68)");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("ResumeId");

                    b.ToTable("ResumeExperiences");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.ResumeLanguage", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LanguageId")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ResumeId")
                        .HasColumnType("varchar(68)");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("ResumeId");

                    b.ToTable("ResumeLanguages");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.ResumeReferences", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReferenceId")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ResumeId")
                        .HasColumnType("varchar(68)");

                    b.HasKey("Id");

                    b.HasIndex("ReferenceId");

                    b.HasIndex("ResumeId");

                    b.ToTable("ResumeReferences");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.ResumeSkills", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResumeId")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("SkillId")
                        .HasColumnType("varchar(68)");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.HasIndex("SkillId");

                    b.ToTable("ResumeSkills");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.Skill", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(68)");

                    b.Property<string>("ContextId")
                        .HasColumnType("varchar(68)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.Link", b =>
                {
                    b.HasOne("ResumeBuilder.Data.Entities.PersonalProfile", null)
                        .WithMany("Links")
                        .HasForeignKey("PersonalProfileId");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.Resume", b =>
                {
                    b.HasOne("ResumeBuilder.Data.Entities.PersonalProfile", "PersonalProfile")
                        .WithMany()
                        .HasForeignKey("PersonalProfileId");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.ResumeAchievements", b =>
                {
                    b.HasOne("ResumeBuilder.Data.Entities.Achievement", "Achievement")
                        .WithMany("Resumes")
                        .HasForeignKey("AchievementId");

                    b.HasOne("ResumeBuilder.Data.Entities.Resume", "Resume")
                        .WithMany("Achievements")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.ResumeCertifications", b =>
                {
                    b.HasOne("ResumeBuilder.Data.Entities.Certification", "Certification")
                        .WithMany("Resumes")
                        .HasForeignKey("CertificationId");

                    b.HasOne("ResumeBuilder.Data.Entities.Resume", "Resume")
                        .WithMany("Certifications")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.ResumeCommunityService", b =>
                {
                    b.HasOne("ResumeBuilder.Data.Entities.CommunityService", "CommunityService")
                        .WithMany("Resumes")
                        .HasForeignKey("CommunityServiceId");

                    b.HasOne("ResumeBuilder.Data.Entities.Resume", "Resume")
                        .WithMany("CommunityServices")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.ResumeEducation", b =>
                {
                    b.HasOne("ResumeBuilder.Data.Entities.Education", "Education")
                        .WithMany("Resumes")
                        .HasForeignKey("EducationId");

                    b.HasOne("ResumeBuilder.Data.Entities.Resume", "Resume")
                        .WithMany("Education")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.ResumeExperience", b =>
                {
                    b.HasOne("ResumeBuilder.Data.Entities.Experience", "Experience")
                        .WithMany("Resumes")
                        .HasForeignKey("ExperienceId");

                    b.HasOne("ResumeBuilder.Data.Entities.Resume", "Resume")
                        .WithMany("Experience")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.ResumeLanguage", b =>
                {
                    b.HasOne("ResumeBuilder.Data.Entities.Language", "Language")
                        .WithMany("Resumes")
                        .HasForeignKey("LanguageId");

                    b.HasOne("ResumeBuilder.Data.Entities.Resume", "Resume")
                        .WithMany("Languages")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.ResumeReferences", b =>
                {
                    b.HasOne("ResumeBuilder.Data.Entities.Reference", "Reference")
                        .WithMany("Resumes")
                        .HasForeignKey("ReferenceId");

                    b.HasOne("ResumeBuilder.Data.Entities.Resume", "Resume")
                        .WithMany("References")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("ResumeBuilder.Data.Entities.ResumeSkills", b =>
                {
                    b.HasOne("ResumeBuilder.Data.Entities.Resume", "Resume")
                        .WithMany("Skills")
                        .HasForeignKey("ResumeId");

                    b.HasOne("ResumeBuilder.Data.Entities.Skill", "Skill")
                        .WithMany("Resumes")
                        .HasForeignKey("SkillId");
                });
#pragma warning restore 612, 618
        }
    }
}