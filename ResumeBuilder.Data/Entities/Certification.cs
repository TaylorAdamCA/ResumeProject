using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ResumeBuilder.Data.Entities
{
    public class Certification : BaseEntity
    {
        [Required]
        [Column(TypeName = "varchar(128)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(128)")]
        public string CertificateAuthority { get; set; }

        [Required]
        [Column(TypeName = "varchar(128)")]
        public string Level { get; set; }

        [Required]
        public DateTime DateReceived { get; set; }
    }
}