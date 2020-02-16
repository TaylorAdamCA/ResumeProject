using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ResumeBuilder.Data.Entities;
using ResumeBuilder.Models.ViewModels;

namespace ResumeBuilder.Models
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<PersonalProfileModel, PersonalProfile>();
        }
    }
}