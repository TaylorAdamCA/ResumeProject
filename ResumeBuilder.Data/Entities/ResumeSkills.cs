using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Data.Entities
{
    /// <summary>
    /// Join table for resume and skills
    /// </summary>
    public class ResumeSkills : BaseEntity
    {
        public Resume Resume { get; set; }
        public Skill Skill { get; set; }
        public string ResumeId { get; set; }
        public string SkillId { get; set; }
    }
}