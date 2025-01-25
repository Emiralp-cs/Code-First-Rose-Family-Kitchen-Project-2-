using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class PhotoGallery
    {
        public int PhotoGalleryId { get; set; }

        [Required(ErrorMessage = "This field required!")]
        public string ImageUrl { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}