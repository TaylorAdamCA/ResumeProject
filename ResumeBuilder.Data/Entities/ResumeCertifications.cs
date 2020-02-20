using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Data.Entities
{
    /// <summary>
    /// Join table for certification & resume
    /// </summary>
    public class ResumeCertifications : BaseEntity
    {
        public Certification Certification { get; set; }
        public Resume Resume { get; set; }
        public string ResumeId { get; set; }
        public string CertificationId { get; set; }
    }
}