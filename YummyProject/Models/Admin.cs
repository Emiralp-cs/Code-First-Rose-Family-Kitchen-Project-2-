using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(70, ErrorMessage = "Maximum 70 characters!")]
        [MinLength(3, ErrorMessage = "En az 3 karakterden oluşabilir!")]
        public string NameSurname { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(70, ErrorMessage = "Maximum 70 characters!")]
        [MinLength(3, ErrorMessage = "En az 3 karakterden oluşabilir!")]

        public string Username { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(10, ErrorMessage = "Maximum 10 characters!")]
        [MinLength(8, ErrorMessage = "En az 8 karakterden oluşabilir!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        
        public string ImageUrl { get; set; }


        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }

    }
}