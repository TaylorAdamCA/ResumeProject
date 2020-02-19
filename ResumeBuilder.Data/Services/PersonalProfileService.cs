using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ResumeBuilder.Data.Entities;
using ResumeBuilder.Data.Services.Interfaces;

namespace ResumeBuilder.Data.Services
{
    public class PersonalProfileService : BaseService<PersonalProfile>, IPersonalProfileService
    {
        public PersonalProfileService(ApplicationDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Maps the personal profile model to the view, might add DTO's in the future
        /// </summary>

        public async Task<PersonalProfile> Create(string contextId, string firstName, string lastName,
            string phoneNumber, string emailAddress, string address, string country,
            string countryCode, string postalCode, List<Link> links)
        {
            PersonalProfile personalProfile = new PersonalProfile
            {
                Id = Guid.NewGuid().ToString(),
                ContextId = contextId,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                EmailAddress = emailAddress,
                Address = address,
                Country = country,
                CountryCode = countryCode,
                PostalCode = postalCode,
                Links = links
            };

            return await AddAsync(personalProfile);
        }

        /// <summary>
        /// Gets the personal profile corresponding to the user currently signed in
        /// </summary>
        /// <param name="contextId"></param>
        /// <returns></returns>
        public async Task<PersonalProfile> GetProfileByContextIdAsync(string userId)
        {
            return await FindAsync(p => p.ContextId == userId);
        }
    }
}