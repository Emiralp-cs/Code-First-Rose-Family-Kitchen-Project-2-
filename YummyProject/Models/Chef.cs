using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class Chef
    {
        public int ChefId { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(40, ErrorMessage = "Maximum 40 characters!")]
        public string ChefName { get; set; }


        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "This field is required!")]

        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please enter 3 to 20 characters!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This field is required!")]

        [StringLength(200, MinimumLength = 10, ErrorMessage = "Please enter 10 to 200 characters!")]
        public string Description { get; set; }

        public virtual List<ChefSocial> ChefSocials { get; set; }


        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}