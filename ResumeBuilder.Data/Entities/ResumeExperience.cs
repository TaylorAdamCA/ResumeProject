using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Data.Entities
{
    /// <summary>
    /// Join table for resume and experience
    /// </summary>
    public class ResumeExperience : BaseEntity
    {
        public Resume Resume { get; set; }
        public Experience Experience { get; set; }
        public string ExperienceId { get; set; }
        public string ResumeId { get; set; }
    }
}