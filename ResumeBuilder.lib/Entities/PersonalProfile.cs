using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ResumeBuilder.lib.Entities
{
    public class PersonalProfile : BaseEntity
    {
        //TODO Upload a picture

        [Required]
        [Display(Name = "First Name")]
        [Column(TypeName = "varchar(128)")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "First Last")]
        [Column(TypeName = "varchar(128)")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Address")]
        [Column(TypeName = "varchar(256)")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Country")]
        [Column(TypeName = "varchar(74)")]
        public string Country { get; set; }

        [Display(Name = "Country Code")]
        [Column(TypeName = "varchar(2)")]
        public string? CountryCode { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        [Column(TypeName = "varchar(32)")]
        public string PostalCode { get; set; }

        [Display(Name = "Full Name")]
        public string FullName => LastName + " " + FirstName;

        /// <summary>
        /// Links to github, linked-in, etc
        /// </summary>
        public List<Links> Links { get; set; }
    }
}