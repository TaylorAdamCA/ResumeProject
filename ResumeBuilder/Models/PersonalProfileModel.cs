using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using ResumeBuilder.Data;
using ResumeBuilder.Data.Entities;

namespace ResumeBuilder.Models
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
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Display(Name = "Full Name")]
        public string FullName => LastName + " " + FirstName;

        public List<SelectListItem> CountriesList => CountryArrays.Names.Select((a, i) => new SelectListItem
        {
            Value = CountryArrays.Abbreviations[i],
            Text = a
        }).ToList();

        /// <summary>
        /// Links to github, linked-in, etc
        /// </summary>
        public List<Links> Links { get; set; }
    }
}