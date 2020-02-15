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
            int phoneNumber, string emailAddress, string address, string country,
            string countryCode, string postalCode, List<Links> links)
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
    }
}