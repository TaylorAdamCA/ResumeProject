using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ResumeBuilder.Data.Entities
{
    public class Reference : BaseEntity
    {
        [Required]
        [Column(TypeName = "varchar(128)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(128)")]
        public string PositionInCompany { get; set; }

        [Required]
        [Column(TypeName = "varchar(128)")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Not requires, but must have at least an email or a phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public ICollection<ResumeReferences> Resumes { get; set; }
    }
}