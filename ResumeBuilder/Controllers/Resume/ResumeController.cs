using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ResumeBuilder.Data.Services.Interfaces;
using ResumeBuilder.Models.ViewModels.Resume;

namespace ResumeBuilder.Controllers.Resume
{
    public class ResumeController : Controller
    {
        private readonly IResumeService _resumeService;
        private readonly IMapper _mapper;

        public ResumeController(IResumeService resumeService, IMapper mapper)
        {
            _resumeService = resumeService;
            _mapper = mapper;
        }

        /// <summary>
        /// Gets all of this users resumes based on their user id and returns the view
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            var resumes = await _resumeService.FindAllIncludingAllAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return View(resumes);
        }

        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// POST: PersonalProfile/Create
        /// </summary>
        /// <param name="resumeModel"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(NewResumeModel resumeModel)
        {
            // TODO: Country is invalid
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var resume = _mapper.Map<ResumeViewModel>(await _resumeService.CreateNewResume(userId, resumeModel.Name));

                RedirectToAction(nameof(Edit), new { Resume = resume });
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Resume/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            return View(await _resumeService.FindIncludingAllAsync(r => r.Id == id));
        }
    }
}