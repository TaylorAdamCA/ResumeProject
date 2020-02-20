using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ResumeBuilder.Data.Entities
{
    public class Achievement : BaseEntity
    {
        [Required]
        [Column(TypeName = "varchar(128)")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<ResumeAchievements> Resumes { get; set; }
    }
}