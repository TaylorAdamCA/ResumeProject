using System;
using System.Collections.Generic;
using System.Text;
using ResumeBuilder.Data.Entities;
using ResumeBuilder.Data.Services.Interfaces;

namespace ResumeBuilder.Data.Services
{
    public class ExperienceService : BaseService<Experience>, IExperienceService
    {
        public ExperienceService(ApplicationDbContext context) : base(context)
        {
        }
    }
}