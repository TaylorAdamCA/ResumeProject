using System.Collections.Generic;
using ResumeBuilder.Data.Entities;

namespace ResumeBuilder.Models.ViewModels.Resume
{
    public class ResumeViewModel
    {
        public string Name { get; set; }

        public string Id { get; set; }

        // Add Templates in future
        public string Template => "Default";

        public PersonalProfile PersonalProfile { get; set; }

        public List<ExperienceViewModel> Experience { get; set; }

        public List<Achievement> Achievements { get; set; }

        public List<Certification> Certifications { get; set; }

        public List<CommunityService> CommunityServices { get; set; }

        public List<Education> Education { get; set; }

        public List<Language> Languages { get; set; }

        public List<Reference> References { get; set; }

        public List<Skill> Skills { get; set; }
    }
}