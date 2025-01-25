using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(100, ErrorMessage = "Maximum 100 characters!")]
        public string NameSurname { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(100, ErrorMessage = "Maximum 100 characters!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(200, ErrorMessage = "Maximum 200 characters!")]

        public string Comment { get; set; }

        public int Rating { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }






    }
}