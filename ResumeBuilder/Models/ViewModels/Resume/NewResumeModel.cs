using System.ComponentModel.DataAnnotations;

namespace ResumeBuilder.Models.ViewModels.Resume
{
    public class NewResumeModel
    {
        [Required]
        public string Name { get; set; }
    }
}