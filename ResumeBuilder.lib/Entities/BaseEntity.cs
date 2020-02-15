using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ResumeBuilder.lib.Entities
{
    public class BaseEntity
    {
        /// <summary>
        /// Id column, I use GUID's
        /// </summary>
        [Key]
        [Required]
        [Column(TypeName = "varchar(68)")]
        public string Id { get; set; }

        /// <summary>
        /// The context for this entity, mainly user id
        /// </summary>
        [Column(TypeName = "varchar(68)")]
        public string ContextId { get; set; }

        /// <summary>
        /// The date this entity was created
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// The last date this entity was updated
        /// </summary>
        public DateTime DateUpdated { get; set; }
    }
}