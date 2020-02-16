using System.ComponentModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ResumeBuilder.Data.Services;
using ResumeBuilder.Models;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using ResumeBuilder.Data.Services.Interfaces;
using ResumeBuilder.Models.ViewModels;

namespace ResumeBuilder.Controllers.Resume
{
    public class PersonalProfileController : Controller
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
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var personalProfile = await _personalProfileService.GetProfileByContextIdAsync(userId);
            if (personalProfile != null)
            {
                return View(_mapper.Map<PersonalProfileModel>(personalProfile));
            }

            return RedirectToAction(nameof(Create));
        }

        // GET: PersonalProfile/Create
        public ActionResult Create()
        {
            return View();
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
                await _personalProfileService.Create(User.FindFirstValue(ClaimTypes.NameIdentifier),
                      personalProfileModel.FirstName,
                      personalProfileModel.LastName,
                      personalProfileModel.PhoneNumber,
                      personalProfileModel.EmailAddress,
                      personalProfileModel.Address,
                      personalProfileModel.Country.Country,
                      personalProfileModel.Country.CountryCode,
                      personalProfileModel.PostalCode,
                      personalProfileModel.Links).ConfigureAwait(true);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: PersonalProfile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
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