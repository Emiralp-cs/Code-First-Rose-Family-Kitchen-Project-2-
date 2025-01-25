using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class About
    {


        public int AboutId { get; set; }

        public string ImageUrl { get; set; }


        public string ImageUrl2 { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(70, ErrorMessage = "Maximum 70 characters!")]
        [MinLength(3, ErrorMessage = "Minimum 3 characters!")]
        public string Item1 { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(70, ErrorMessage = "Maximum 70 characters!")]
        [MinLength(3, ErrorMessage = "Minimum 3 characters!")]
        public string Item2 { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(70, ErrorMessage = "Maximum 70 characters!")]
        [MinLength(3, ErrorMessage = "Minimum 3 characters!")]
        public string Item3 { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(400, ErrorMessage = "Maximum 400 characters!")]
        [MinLength(10, ErrorMessage = "Minimum 10 characters!")]
        public string Description { get; set; }
        [Required(ErrorMessage ="This field is required!")]
        public string VideoUrl { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(20,ErrorMessage = "Maximum 70 characters!")]
        [MinLength(10,ErrorMessage ="Minimum 10 characters!")]
        public string PhoneNumber { get; set; }


        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile2 { get; set; }





    }
}