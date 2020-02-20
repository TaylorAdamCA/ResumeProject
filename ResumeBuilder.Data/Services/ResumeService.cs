using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Data.Entities;
using ResumeBuilder.Data.Services.Interfaces;

namespace ResumeBuilder.Data.Services
{
    /// <summary>
    /// All services directly related to creating a resume
    /// </summary>
    public class ResumeService : BaseService<Resume>, IResumeService
    {
        public ResumeService(ApplicationDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Gets all the resumes for for this user
        /// Eagerly loads all other required info
        /// TODO: see how performance is on this, might be to many JOINS
        /// </summary>
        /// <param name="contextId"></param>
        /// <returns></returns>
        public async Task<List<Resume>> FindAllIncludingAllAsync(string contextId)
        {
            return await _context.Resumes
                .Include(r => r.Achievements)
                .Include(r => r.Certifications)
                .Include(r => r.CommunityServices)
                .Include(r => r.Education)
                .Include(r => r.Experience)
                .Include(r => r.Languages)
                .Include(r => r.PersonalProfile)
                .Include(r => r.References)
                .Include(r => r.Skills)
                .Where(r => r.ContextId == contextId)
                .ToListAsync();
        }

        public async Task<Resume> FindIncludingAllAsync(Expression<Func<Resume, bool>> match)
        {
            return await _context.Resumes
                .Include(r => r.Achievements)
                 .ThenInclude(r => r.Achievement)
                .Include(r => r.Certifications)
                  .ThenInclude(r => r.Certification)
                .Include(r => r.CommunityServices)
                  .ThenInclude(r => r.CommunityService)
                .Include(r => r.Education)
                  .ThenInclude(r => r.Education)
                .Include(r => r.Experience)
                 .ThenInclude(r => r.Experience)
                .Include(r => r.Languages)
                 .ThenInclude(r => r.Language)
                .Include(r => r.PersonalProfile)
                .Include(r => r.References)
                  .ThenInclude(r => r.Reference)
                .Include(r => r.Skills)
                 .ThenInclude(r => r.Skill)
                .FirstOrDefaultAsync(match);
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

        /// <summary>
        /// Creates the join between the resume and the experience
        /// </summary>
        /// <param name="resumeId"></param>
        /// <param name="contextId"></param>
        /// <param name="experience"></param>
        /// <returns></returns>
        public async Task AddExperienceToResume(string resumeId, string contextId, Experience experience)
        {
            Resume resume = await FindAsync(r => r.Id == resumeId);

            experience.Id = Guid.NewGuid().ToString();
            experience.ContextId = contextId;
            experience.DateCreated = DateTime.Now;
            experience.DateUpdated = DateTime.Now;

            ResumeExperience join = new ResumeExperience
            {
                Id = Guid.NewGuid().ToString(),
                ContextId = contextId,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                Resume = resume,
                ResumeId = resumeId,
                Experience = experience,
                ExperienceId = experience.Id
            };
            await _context.Experiences.AddAsync(experience);
            await _context.ResumeExperiences.AddAsync(join);
            await _context.SaveChangesAsync();
        }
    }
}