using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using HandlebarsDotNet;
using Microsoft.AspNetCore.Mvc;
using ResumeBuilder.Data.Services.Interfaces;
using ResumeBuilder.Models.ViewModels.Resume;

namespace ResumeBuilder.Controllers.Resume
{
    /// <summary>
    /// The controller for viewing your resume, might move to resume controller as it may be redundant to have both
    /// TODO: make sure this is necessary or move it to resume controller
    /// </summary>
    public class ViewResumeController : Controller
    {
        private readonly IResumeService _resumeService;
        private readonly IMapper _mapper;

        public ViewResumeController(IResumeService resumeService, IMapper mapper)
        {
            _resumeService = resumeService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            // Will probably have to get the resume id here
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var resumes = await _resumeService.FindAllIncludingAllAsync(userId);
            var resume = _mapper.Map<ICollection<Data.Entities.Resume>, IEnumerable<ResumeViewModel>>(resumes);
            return View(resume);
        }

        public async Task<IActionResult> ViewResume(string resumeId)
        {
            var resume = _mapper.Map<Data.Entities.Resume, ResumeViewModel>(await _resumeService.FindIncludingAllAsync(r => r.Id == resumeId));
            return View(resume);
        }
    }
}