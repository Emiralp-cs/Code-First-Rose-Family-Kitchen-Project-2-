using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class ConInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Please enter 5 to 100 characters!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Please enter 5 to 100 characters!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Please enter 5 to 100 characters!")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Lütfen 5 - 100 Karakter Arasında Girin!")]
        public string OpeningHours { get; set; }

    }
}