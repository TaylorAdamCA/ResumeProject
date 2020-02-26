using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ResumeBuilder.Data.Services;
using ResumeBuilder.Models;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ResumeBuilder.Data.Entities;
using ResumeBuilder.Data.Services.Interfaces;
using ResumeBuilder.Misc;
using ResumeBuilder.Models.ViewModels;

namespace ResumeBuilder.Controllers.Resume
{
    public class PersonalProfileController : BaseController
    {
        public PersonalProfileController(IPersonalProfileService personalProfileService, UserManager<IdentityUser> userManager, IMapper mapper)
        {
            _personalProfileService = personalProfileService;

            _mapper = mapper;
        }

        private readonly IPersonalProfileService _personalProfileService;

        private readonly IMapper _mapper;

        // GET: PersonalProfile
        public async Task<ActionResult> Index()
        {
            var personalProfile = await CheckForPersonalProfile();
            if (personalProfile != null)
            {
                return View(_mapper.Map<PersonalProfileModel>(personalProfile));
            }

            return RedirectToAction(nameof(Create));
        }

        // GET: PersonalProfile/Create
        public async Task<ActionResult> Create()
        {
            var personalProfile = await CheckForPersonalProfile();
            if (personalProfile != null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        /// <summary>
        /// Checks for an existing profile
        /// </summary>
        /// <returns></returns>
        private async Task<PersonalProfile> CheckForPersonalProfile()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var personalProfile = await _personalProfileService.GetProfileByContextIdAsync(userId);
            return personalProfile;
        }

        /// <summary>
        /// POST: PersonalProfile/Create
        /// </summary>
        /// <param name="personalProfileModel"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonalProfileModel personalProfileModel)
        {
            // TODO: Country is invalid
            if (ModelState.IsValid)
            {
                var country = CountryArrays.Names[int.Parse(personalProfileModel.CountryIndex)];
                var countryCode = CountryArrays.Abbreviations[int.Parse(personalProfileModel.CountryIndex)];
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                /// Maps the personal profile model to the viewmodel, might add DTO's in the future
                PersonalProfile personalProfile = _mapper.Map<PersonalProfile>(personalProfileModel);
                personalProfile.Country = country;
                personalProfile.CountryCode = countryCode;
                personalProfile.ContextId = userId;
                personalProfile.Id = Guid.NewGuid().ToString();
                personalProfile.DateUpdated = DateTime.Now;
                personalProfile.DateCreated = DateTime.Now;

                /*PersonalProfile personalProfile = new PersonalProfile
                {
                    Id =
                    ContextId = userId,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    FirstName = personalProfileModel.FirstName,
                    LastName = personalProfileModel.LastName,
                    PhoneNumber = personalProfileModel.PhoneNumber,
                    EmailAddress = personalProfileModel.EmailAddress,
                    Address = personalProfileModel.Address,
                    Country = country,
                    CountryCode = countryCode,
                    City = personalProfileModel.City,
                    State = personalProfileModel.State,
                    PostalCode = personalProfileModel.PostalCode,
                    Links = personalProfileModel.Links
                };*/
                await _personalProfileService.AddAsync(personalProfile);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: PersonalProfile/Edit/5
        /// <summary>
        /// Gets the personal profile and maps it to the view model, allowing the user to edit it
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ActionResult> Edit(string id)
        {
            return View(_mapper.Map<PersonalProfileModel>(await _personalProfileService.FindAsync(pp => pp.Id == id)));
        }

        // POST: PersonalProfile/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Create));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonalProfile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonalProfile/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}