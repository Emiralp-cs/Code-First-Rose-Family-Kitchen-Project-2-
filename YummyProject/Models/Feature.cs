using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class Feature
    {
        public int FeatureId { get; set; }

        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(100, ErrorMessage = "Maximum 100 characters!")]
        [MinLength(5, ErrorMessage = "Minimum 5 characters!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "This field required!")]
        [MaxLength(300, ErrorMessage = "Maximum 300 characters!")]
        [MinLength(10, ErrorMessage = "Minimum 5 characters!")]

        public string Description { get; set; }

        [Required(ErrorMessage = "This field required!")]

        public string VideoUrl { get; set; }


        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}