using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        [Required(ErrorMessage = "This field required!")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Please enter 5 to 100 characters!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field required!")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Please enter 5 to 100 characters!")]

        public string Email { get; set; }
        [Required(ErrorMessage = "This field required!")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Please enter 5 to 100 characters!")]
        public string Subject { get; set; } 
        [Required(ErrorMessage = "This field required!")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Please enter 5 to 100 characters!")]

        public string MessageContent { get; set; }

        public bool Isread { get; set; }

    }
}