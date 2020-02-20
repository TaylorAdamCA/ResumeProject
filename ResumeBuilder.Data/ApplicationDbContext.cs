using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Data.Entities;

namespace ResumeBuilder.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PersonalProfile> PersonalProfiles { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<CommunityService> CommunityServices { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<ResumeAchievements> ResumeAchievements { get; set; }
        public DbSet<ResumeCertifications> ResumeCertifications { get; set; }
        public DbSet<ResumeCommunityService> ResumeCommunityServices { get; set; }
        public DbSet<ResumeEducation> ResumeEducation { get; set; }
        public DbSet<ResumeExperience> ResumeExperiences { get; set; }
        public DbSet<ResumeLanguage> ResumeLanguages { get; set; }
        public DbSet<ResumeReferences> ResumeReferences { get; set; }
        public DbSet<ResumeSkills> ResumeSkills { get; set; }
    }
}