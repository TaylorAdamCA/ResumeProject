using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HandlebarsDotNet;
using Microsoft.AspNetCore.Mvc;

namespace ResumeBuilder.Controllers.Resume
{
    public class ViewResumeController : Controller
    {
        public IActionResult Index()
        {
            /*var body = string.Empty;
            using (StreamReader reader = new StreamReader("wwwroot/templates/index.cshtml"))
            {
                body = reader.ReadToEnd();
            }
            var template = Handlebars.Compile(body);
            var data = new
            {
                Name = "Taylor Adam",
                Email = "tjadam1993@gmail.com",
                PhoneNumber = "2508992055",
                Address = "1102 Cameron Ave, unit 145",
                City = "Kelowna",
                State = "BC",
                Country = "Canada",
                PostalCode = "V1Y0B2",
                SectionTitle = "Professional Experience",
                Title = "Full Stack ASP.NET Core Developer",
                Company = "Contracting for Impreglon Canada Ltd - Oilfield Coatings",
                StartDate = DateTime.Now,
                EndDate = "present",
                AdditionalInfo = "Full Stack  \r\n·\tLearned and used various technologies including C#, most of the dot net suite, SQL Server, Entity Framework Core, and Azure\r\n·\tResponsible for converting current order entry program, written in VFP (Visual Fox Pro 9), into a Web App\r\n·\tI am the sole developer but communicate with employees at Impreglon for feedback.\r\n·\tPart time employment while completing COSCI degree (avg. 10 hrs. a week)\r\n"
            };
            var result = template(data);*/
            return View();
        }
    }
}