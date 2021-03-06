﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeBuilder.Data.Entities
{
    public class Resume : BaseEntity
    {
        [Required]
        [Column(TypeName = "varchar(74)")]
        public string Name { get; set; }

        // Add Templates in future
        public string Template => "Default";

        public PersonalProfile PersonalProfile { get; set; }

        public ICollection<ResumeExperience> Experience { get; set; }

        public ICollection<ResumeAchievements> Achievements { get; set; }

        public ICollection<ResumeCertifications> Certifications { get; set; }

        public ICollection<ResumeCommunityService> CommunityServices { get; set; }

        public ICollection<ResumeEducation> Education { get; set; }

        public ICollection<ResumeLanguage> Languages { get; set; }

        public ICollection<ResumeReferences> References { get; set; }

        public ICollection<ResumeSkills> Skills { get; set; }
    }
}