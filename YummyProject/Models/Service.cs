using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(100, ErrorMessage = "Maximum 100 characters!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(200, ErrorMessage = "Maximum 200 characters!")]
        public string Description { get; set; }
        public string Icon { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}