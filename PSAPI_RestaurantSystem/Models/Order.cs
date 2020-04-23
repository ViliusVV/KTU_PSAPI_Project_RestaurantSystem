using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    }
}
