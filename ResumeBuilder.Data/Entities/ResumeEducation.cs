using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Data.Entities
{
    /// <summary>
    /// Join table for resume and education
    /// </summary>
    public class ResumeEducation : BaseEntity
    {
        public Education Education { get; set; }
        public Resume Resume { get; set; }
        public string ResumeId { get; set; }
        public string EducationId { get; set; }
    }
}