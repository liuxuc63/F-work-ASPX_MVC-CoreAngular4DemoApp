﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreAngular4DemoApp.Server.Entities
{
    public class Language : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(7)]
        public string Locale { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public ICollection<ContentText> ContentTexts { get; set; }
    }
}
