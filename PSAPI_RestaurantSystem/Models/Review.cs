using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [NotMapped]
        public static List<SelectListItem> digits = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = "Puiku", Value = "5"
                },
                new SelectListItem
                {
                    Text = "Gerai", Value = "4"
                },
                new SelectListItem
                {
                    Text = "Vidutiniškai", Value = "3"
                },
                new SelectListItem
                {
                    Text = "Prastai", Value = "2"
                },
                new SelectListItem
                {
                    Text = "Blogai", Value = "1"
                }

            };
    }
}
