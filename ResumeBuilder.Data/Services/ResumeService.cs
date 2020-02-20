using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResumeBuilder.Data.Entities;
using ResumeBuilder.Data.Services.Interfaces;

namespace ResumeBuilder.Data.Services
{
    public class ResumeService : BaseService<Resume>, IResumeService
    {
        public ResumeService(ApplicationDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Creates a new resume object in the database
        /// </summary>
        /// <param name="contextId"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<Resume> CreateNewResume(string contextId, string name)
        {
            return await AddAsync(new Resume
            {
                Id = Guid.NewGuid().ToString(),
                ContextId = contextId,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                Name = name,
                PersonalProfile = null,
                Experience = null,
                Achievements = null,
                Certifications = null,
                CommunityServices = null,
                Education = null,
                Languages = null,
                References = null,
                Skills = null
            });
        }
    }
}