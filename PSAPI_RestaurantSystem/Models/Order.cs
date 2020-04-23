using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    public class Order
    {
        [Key]
        public int OrderNum { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public int State { get; set; }

        // Relationship
        // Waiter to order (1 to *)
        public int ManagedByWaiterId { get; set; }
        public Waiter ManagedBy { get; set; }

        // Order to tableoccupancy (1 to *)
        public List<TableOccupancy> TableOccupancies {get;set;}

        // Order to orderedmeal (1 to *)
        [InverseProperty("InOrder")]
        public List<OrderedMeal> OrderedMeals { get; set; }

    }
}
