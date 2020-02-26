using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ResumeBuilder.Data.Services.Interfaces;
using ResumeBuilder.Models.ViewModels;

namespace ResumeBuilder.ViewComponents
{
    [ViewComponent]
    public class Experience : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(ExperienceViewModel experienceViewModel)
        {
            return View(experienceViewModel);
        }
    }
}