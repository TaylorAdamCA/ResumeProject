using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ResumeBuilder.Data.Entities;
using ResumeBuilder.Models.ViewModels;
using ResumeBuilder.Models.ViewModels.Resume;

namespace ResumeBuilder.Models
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<PersonalProfileModel, PersonalProfile>();
            CreateMap<PersonalProfile, PersonalProfileModel>();
            CreateMap<ResumeViewModel, Resume>();
            CreateMap<Resume, ResumeViewModel>();
            CreateMap<Experience, ExperienceViewModel>();
            CreateMap<ExperienceViewModel, Experience>();
        }
    }
}