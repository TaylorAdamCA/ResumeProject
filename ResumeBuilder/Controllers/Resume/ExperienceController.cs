using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResumeBuilder.Data.Entities;
using ResumeBuilder.Data.Services.Interfaces;
using ResumeBuilder.Models.ViewModels;

namespace ResumeBuilder.Controllers.Resume
{
    public class ExperienceController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IResumeService _resumeService;

        public ExperienceController(IMapper mapper, IResumeService resumeService)
        {
            _mapper = mapper;
            _resumeService = resumeService;
        }

        // GET: Experience
        public ActionResult Index()
        {
            return View();
        }

        // GET: Experience/Create/string
        /// <summary>
        /// Create a new  experience object related to this resume
        /// </summary>
        /// <param name="resumeId"></param>
        /// <returns></returns>
        public ActionResult Create([FromQuery]string resumeId)
        {
            ExperienceViewModel model = new ExperienceViewModel();
            model.ResumeId = resumeId;
            return View(model);
        }

        // POST: Experience/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ExperienceViewModel experienceViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Map to experience model and create it, along with adding a row to the join table
                    var experience = _mapper.Map<Experience>(experienceViewModel);

                    await _resumeService.AddExperienceToResume(experienceViewModel.ResumeId, User.FindFirstValue(ClaimTypes.NameIdentifier),
                         experience);
                }

                return RedirectToAction("Edit", "Resume", new { id = experienceViewModel.ResumeId });
            }
            catch (Exception e)
            {
                ViewBag.Erros = e.Message;
                return View();
            }
        }

        // GET: Experience/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Experience/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Experience/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Experience/Delete/5
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