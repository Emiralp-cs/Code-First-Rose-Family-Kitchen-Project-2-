using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class SocialMediaLogo
    {
        public int SocialMediaLogoId { get; set; }
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please enter 3 to 20 characters!")]
        public string SocialMediaLogos { get; set; }
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please enter 3 to 20 characters!")]
        public string SocialMediaLogoName { get; set; }



    }
}