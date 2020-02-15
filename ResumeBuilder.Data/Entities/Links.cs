using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeBuilder.Data.Entities
{
    public class Links : BaseEntity
    {
        [Required]
        [Column(TypeName = "varchar(256)")]
        public string Url { get; set; }

        [Required]
        [Column(TypeName = "varchar(128)")]
        public string Name { get; set; }
    }
}