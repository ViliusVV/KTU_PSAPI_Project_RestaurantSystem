using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public int ReviewText { get; set; }

        [Required]
        public DateTime ReviewDate { get; set; }


        // Relationships
        // User to review (0 to *)
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
