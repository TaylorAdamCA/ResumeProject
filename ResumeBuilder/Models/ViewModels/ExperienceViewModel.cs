using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;

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
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date/ Leave blank if still employed")]
        public DateTime EndDate { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Additional Info/ Description of Duties")]
        public string AdditionalInfo { get; set; }
    }
}