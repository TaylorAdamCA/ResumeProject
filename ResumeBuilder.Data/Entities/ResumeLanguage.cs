using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Data.Entities
{
    /// <summary>
    /// Join table for resume and language
    /// </summary>
    public class ResumeLanguage : BaseEntity
    {
        public Language Language { get; set; }
        public Resume Resume { get; set; }
        public string ResumeId { get; set; }
        public string LanguageId { get; set; }
    }
}