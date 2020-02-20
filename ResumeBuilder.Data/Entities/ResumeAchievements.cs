using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Data.Entities
{
    // Join table for resumes & achievements
    public class ResumeAchievements : BaseEntity
    {
        public Achievement Achievement { get; set; }
        public string AchievementId { get; set; }
        public string ResumeId { get; set; }
        public Resume Resume { get; set; }
    }
}