using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class ChefSocial
    {
        public int ChefSocialId { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }

        public string SocialMediaName { get; set; }

        public int ChefId { get; set; }

        public virtual Chef Chef { get; set; } //1 tane sosyal medya hesabının 1 tane sahibi olur.
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }

    }
}