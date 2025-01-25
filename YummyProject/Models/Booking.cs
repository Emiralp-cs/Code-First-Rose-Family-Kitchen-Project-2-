using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(70, ErrorMessage = "Maximum 70 characters!")]
        [MinLength(3, ErrorMessage = "Minimum 3 characters!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(70, ErrorMessage = "Maximum 70 characters!")]
        [MinLength(3, ErrorMessage = "Minimum 3 characters!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(70, ErrorMessage = "Maximum 70 characters!")]
        [MinLength(3, ErrorMessage = "Minimum 3 characters!")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "This field is required!")]
       
        public DateTime BookingDate { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public int PersonCount { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(200, ErrorMessage = "Maximum 200 characters!")]
        [MinLength(3, ErrorMessage = "Minimum 3 characters!")]
        public string MessageContent { get; set; }
        public bool? IsApproved { get; set; }




    }
}