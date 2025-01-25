using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class Event
    {
        public int EventId { get; set; }
        [Required(ErrorMessage = "This field is required!")]

        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(50, ErrorMessage = "Maximum 50 characters!")]
        [MinLength(3, ErrorMessage = "Minimum 3 charaters!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(200, ErrorMessage = "Maximum 50 characters")]
        [MinLength(10, ErrorMessage = "Minimum 3 charaters!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(50, ErrorMessage = "Maximum 50 characters")]
        [MinLength(3, ErrorMessage = "Minimum 3 charaters!")]
        public string Price { get; set; }


        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}