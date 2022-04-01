using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MVC.Models.validator;

namespace MVC.Models
{
    public class Kupac
    {
        public int IDKupac { get; set; }
        [Required(ErrorMessage = "Ime je obavezno")]
        [validatorIme]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Prezime je obavezno!")]
        public string Prezime { get; set; }
        [Required(ErrorMessage = "Adresa elektroničke pošte je obavezna!")]
        [EmailAddress(ErrorMessage = "Elektronička adresa nije ispravna!")]

        public string Email { get; set; }
        public string Telefon { get; set; }
        public Grad Grad { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}