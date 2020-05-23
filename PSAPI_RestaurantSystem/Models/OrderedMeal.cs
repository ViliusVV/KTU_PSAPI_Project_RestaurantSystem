using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    public class OrderedMeal
    {
        [Key]
        public int OrderedMealId { get; set; }
        
        [Required]
        [Display(Name ="Vnt. kaina")]
        public double Price { get; set; }
        
        [Required]
        [Display(Name ="Kiekis")]
        public int Quantity { get; set; }

        [Display(Name ="Pastabos")]
        public string Comment { get; set; }

        // Relationships
        // Takeoutorder to orderedmeal (0 to 1.*)
        public int? InTakeoutTakeoutOrderId { get; set; }
        public TakeoutOrder InTakeout { get; set; }

        // Order to orderedmeal (0 to *)
        public int? InOrderOrderId { get; set; }
        public Order InOrder { get; set; }

        // Menuentry to orderedmeal (1 to *)
        [Display(Name = "Pavadinimas")]
        public int MenuEntryId { get; set; }
        public MenuEntry MenuEntry { get; set; }
    }
}
