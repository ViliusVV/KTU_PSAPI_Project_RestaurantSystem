using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace PSAPIRestaurantSystem.Models.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name="Prisijungimo vardas")]
        public string LoginName { get; set; }
        [Display(Name = "Slaptažodis")]
        public string Password { get; set; }


    }
}
