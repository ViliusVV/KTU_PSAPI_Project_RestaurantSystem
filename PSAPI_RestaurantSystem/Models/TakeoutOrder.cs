using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    public class TakeoutOrder
    {
        [Key]
        [Display(Name = "Užsakymo id")]
        public int TakeoutOrderId { get; set; }

        [Required]
        [Display(Name = "Užsakymo data")]
        public DateTime OrderDate { get; set; }

        [Required]
        [Display(Name = "Užsakyta datai")]
        public DateTime OrderedForDate { get; set; }
        [Display(Name = "Patvirtinimo data")]
        public DateTime ConfirmationDate { get; set; }

        [Required]
        [Display(Name = "Kaina")]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Būsena")]
        public int State { get; set; }


        // Relationship
        // Waiter to takeoutorder (1 to *)
        public int ManagedByWaiterId { get; set; }
        public Waiter ManagedBy { get; set; }

        // User to takeoutorder (0 to *)
        public int OrderedByUserId { get; set; }
        public User OrderedBy { get; set; }

        // Takeoutorder to ordered meal (1 to 1.*)
        [InverseProperty("InTakeout")]
        public List<OrderedMeal> OrderedMeals { get; set; }
    }
}
