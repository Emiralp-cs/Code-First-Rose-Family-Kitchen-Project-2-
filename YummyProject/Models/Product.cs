using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "This field is required")]

        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(100, ErrorMessage = "Maximum 100 characters!")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(300, ErrorMessage = "Maximum 300 characters!")]
        public string Ingredients { get; set; }


        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        //navigation property
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
        public virtual Category Category { get; set; } //Bir ürünün bir tane kategorisi olabilir.



    }
}