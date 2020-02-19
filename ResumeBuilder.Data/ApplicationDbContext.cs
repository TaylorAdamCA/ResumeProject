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
    }
}