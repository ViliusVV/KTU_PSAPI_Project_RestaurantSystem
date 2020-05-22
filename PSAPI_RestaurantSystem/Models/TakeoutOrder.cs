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
        public int TakeoutOrderId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public DateTime OrderedForDate { get; set; }

        public DateTime ConfirmationDate { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
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
