using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using ResumeBuilder.Data.Entities;
using ResumeBuilder.Misc;
using ResumeBuilder.Models.Misc;

namespace ResumeBuilder.Models.ViewModels
{
    public class PersonalProfileModel
    {
        //TODO Upload a picture

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "First Last")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Country")]
        public CountryModel Country { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Display(Name = "Full Name")]
        public string FullName => LastName + " " + FirstName;

        /// <summary>
        /// Links to github, linked-in, etc
        /// </summary>
        public List<Link> Links { get; set; }
    }
}