using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models.validator
{
    public class validatorIme:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int maxZnakova = 10;
            var kupac = validationContext.ObjectInstance as Kupac;

            if (kupac.Ime == null)
            {
                return ValidationResult.Success;
            }

            return kupac.Ime.Length <= maxZnakova ? ValidationResult.Success : new ValidationResult($"Tvoje ima {kupac.Ime.Length} znakova, a najviše smije imati {maxZnakova} znakova!");
        }
    }
}