using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace ResumeBuilder.Models.ViewModels
{
    public class ExperienceViewModel
    {
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Not required, job could be ongoing
        /// </summary>
        [Display(Name = "End Date/ Leave blank if still employed")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required]
        [Display(Name = "Company")]
        public string Company { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Additional Info/ Description of Duties")]
        public string AdditionalInfo { get; set; }

        [HiddenInput]
        public string ResumeId { get; set; }

        /// <summary>
        /// Gets the end date if there is one, other wise assumes you still work here
        /// </summary>
        /// <returns></returns>
        public string GetEndDate() => EndDate == null ? "Present" : EndDate.ToString();
    }
}