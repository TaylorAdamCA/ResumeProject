using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResumeBuilder.Data.Entities;

namespace ResumeBuilder.Data.Services.Interfaces
{
    public interface IPersonalProfileService : IBaseService<PersonalProfile>
    {
        Task<PersonalProfile> Create(string contextId, string firstName, string lastName,
            string phoneNumber, string emailAddress, string address, string country,
            string countryCode, string postalCode, List<Links> links);

        Task<PersonalProfile> GetProfileByContextIdAsync(string userId);
    }
}