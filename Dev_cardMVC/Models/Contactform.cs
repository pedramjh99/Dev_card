using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dev_cardMVC.Models
{
    public class Contactform
    {
        [Required(ErrorMessage = "Please insert Name")]
        public string Name { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Please insert Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please insert Message")]
        public string Message { get; set; }

        public int Service { get; set; }
        public SelectList Services { get; set; }
    }
}
