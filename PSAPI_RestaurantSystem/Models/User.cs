using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public bool Confirmed { get; set; }

        [Required]
        public int LoyalityPoints { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        public DateTime LastLoginDate { get; set; }


    }
}
