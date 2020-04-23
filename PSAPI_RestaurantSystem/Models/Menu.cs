using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }

        [Required]
        public string Title { get; set; }
        
        [Required]
        public DateTime Changed { get; set; }

        // Relationshps
        // Menu to menuentry (1 to *)
        public List<MenuEntry> MenuEntries { get; set; }
    }
}
