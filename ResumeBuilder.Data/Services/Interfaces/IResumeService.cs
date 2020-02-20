using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ResumeBuilder.Data.Entities;

namespace ResumeBuilder.Data.Services.Interfaces
{
    public interface IResumeService : IBaseService<Resume>
    {
        Task<Resume> CreateNewResume(string contextId, string name);

        Task<List<Resume>> FindAllIncludingAllAsync(string contextId);

        Task AddExperienceToResume(string resumeId, string contextId, Experience experience);

        Task<Resume> FindIncludingAllAsync(Expression<Func<Resume, bool>> match);
    }
}