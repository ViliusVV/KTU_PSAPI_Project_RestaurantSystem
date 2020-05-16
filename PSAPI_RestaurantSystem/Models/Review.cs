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
        [Display(Name = "Įvertinimas")]
        public int Rating { get; set; }

        [Required]
        [Display(Name = "Atsiliepimo tekstas")]
        public string ReviewText { get; set; }

        [Required]
        [Display(Name = "Data")]
        public DateTime ReviewDate { get; set; }


        // Relationships
        // User to review (0 to *)
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
