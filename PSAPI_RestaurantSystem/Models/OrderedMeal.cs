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
        public double Price { get; set; }
        
        [Required]
        public int Quantity { get; set; }

        
        public string Comment { get; set; }
    }
}
