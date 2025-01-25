using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class Stats
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Boş Bırakılamaz!")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Please enter 3 to 100 characters!")]
        public string StatsTitle { get; set; }
        [Required(ErrorMessage = "Boş Bırakılamaz!")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Please enter 3 to 100 characters!")]
        public string Description { get; set; }
    }
}