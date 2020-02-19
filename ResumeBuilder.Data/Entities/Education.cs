using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Data.Entities
{
    public class Education
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}