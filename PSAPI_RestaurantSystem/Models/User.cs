using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        // Relationships
        // Person to user (1 to 1)
        public int PersonId { get; set; }
        public Person Person { get; set; }

        // User to Employee (1 to 1)
        public Employee Employee { get; set; }

        // User to review (0 to *)
        public List<Review> Reviews { get; set; }

        // User to reservation (0 to *)
        [InverseProperty("ReservedBy")]
        public List<Reservation> Reservations { get; set; }
    }
}
