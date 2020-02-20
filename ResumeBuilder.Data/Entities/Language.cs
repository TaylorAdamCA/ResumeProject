using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ResumeBuilder.Data.Entities
{
    public class Language : BaseEntity
    {
        [Required]
        [Column(TypeName = "varchar(128)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(128)")]
        public string Proficiency { get; set; }

        public ICollection<ResumeLanguage> Resumes { get; set; }
    }
}