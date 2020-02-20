using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ResumeBuilder.Data.Entities
{
    public class Experience : BaseEntity
    {
        [Required]
        [Column(TypeName = "varchar(128)")]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string AdditionalInfo { get; set; }

        public ICollection<ResumeExperience> Resumes { get; set; }
    }
}