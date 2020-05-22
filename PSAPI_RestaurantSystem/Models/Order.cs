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
        [Display(Name = "Nr")]
        [Key]
        public int OrderNum { get; set; }

        [Display(Name = "Užsakymo data")]
        [Required]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Kaina")]
        [Required]
        public double Price { get; set; }

        [Display(Name = "Trukmė")]
        [Required]
        public int Duration { get; set; }

        [Display(Name = "Būsena")]
        [Required]
        public int State { get; set; }

        // Relationship
        // Waiter to order (1 to *)
        public int? ManagedByWaiterId { get; set; }

        [Display(Name = "Padavėjas")]
        public Waiter ManagedBy { get; set; }

        // Order to tableoccupancy (1 to *)
        public List<TableOccupancy> TableOccupancies {get;set;}

        // Order to orderedmeal (1 to *)
        [InverseProperty("InOrder")]
        public List<OrderedMeal> OrderedMeals { get; set; }

    }
}
