using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeBuilder.Data.Entities
{
    public class PersonalProfile : BaseEntity
    {
        //TODO Upload a picture

        [Required]
        [Column(TypeName = "varchar(128)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(128)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "varchar(64)")]
        public string PhoneNumber { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        [Required]
        [Column(TypeName = "varchar(256)")]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "varchar(74)")]
        public string Country { get; set; }

        [Column(TypeName = "varchar(2)")]
        public string? CountryCode { get; set; }

        [Required]
        [Column(TypeName = "varchar(32)")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Links to github, linked-in, etc
        /// </summary>
        public List<Links> Links { get; set; }
    }
}