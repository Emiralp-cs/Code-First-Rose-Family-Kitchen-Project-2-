using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }

        public string SocialMediaUrl { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(100, ErrorMessage = "Maximum 100 characters!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(100, ErrorMessage = "Maximum 100 characters!")]
        public string Icon { get; set; }

    }
}