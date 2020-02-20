using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Data.Entities
{
    /// <summary>
    /// Join table for resume and community service
    /// </summary>
    public class ResumeCommunityService : BaseEntity
    {
        public CommunityService CommunityService { get; set; }
        public Resume Resume { get; set; }
        public string ResumeId { get; set; }
        public string CommunityServiceId { get; set; }
    }
}