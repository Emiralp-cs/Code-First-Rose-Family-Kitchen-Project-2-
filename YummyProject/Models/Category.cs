using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(70, ErrorMessage = "Maximum 70 characters!")]
        [MinLength(3, ErrorMessage = "Minimum 3 characters!")]
        public string CategoryName { get; set; }

        public virtual List<Product> Products { get; set; }


    }
}