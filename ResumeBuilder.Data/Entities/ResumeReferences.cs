using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Data.Entities
{
    /// <summary>
    /// Join table for resume and references
    /// </summary>
    public class ResumeReferences : BaseEntity
    {
        public Resume Resume { get; set; }
        public Reference Reference { get; set; }
        public string ResumeId { get; set; }
        public string ReferenceId { get; set; }
    }
}