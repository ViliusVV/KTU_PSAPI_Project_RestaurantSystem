using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    public class MenuEntry
    {
        [Key]
        public int MenuEntryId { get; set; }

        [Required]
        public string MenuEntryName { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public DateTime Changed { get; set; }
    }
}
