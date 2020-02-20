using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResumeBuilder.Data.Entities;

namespace ResumeBuilder.Data.Services.Interfaces
{
    public interface IResumeService : IBaseService<Resume>
    {
        Task<Resume> CreateNewResume(string contextId, string name);
    }
}