using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class Rating_Stars
    {
        public int Id { get; set; }
       
        public int Rating_Stars_Counter { get; set; }
        [MaxLength(10)]
        public string Rating_Stars_Selectable { get; set; }
    }
}