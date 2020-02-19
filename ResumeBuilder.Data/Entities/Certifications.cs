using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Data.Entities
{
    public class Certifications
    {
        public string Name { get; set; }
        public string CertificateAuthority { get; set; }
        public string Level { get; set; }
        public DateTime DateReceived { get; set; }
    }
}