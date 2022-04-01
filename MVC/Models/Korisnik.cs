using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Korisnik
    {
        [Required(ErrorMessage = "Korisničko ime je obavezno")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lozinka je obavezna")]
        public string Lozinka { get; set; }
    }
}