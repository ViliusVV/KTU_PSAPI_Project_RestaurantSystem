using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    public class TakeoutOrder
    {
        [Key]
        public int TakeoutOrderNum { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public DateTime OrderedForDate { get; set; }

        public DateTime ConfirmationDate { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int State { get; set; }
    }
}
