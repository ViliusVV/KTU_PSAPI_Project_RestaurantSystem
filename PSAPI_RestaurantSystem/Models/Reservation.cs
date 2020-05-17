using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    public class Reservation
    {
        [Display(Name = "Nr")]
        [Key]
        public int ReservationId { get; set; }

        [Display(Name = "Žmonių kiekis")]
        [Required]
        public int PeopleCount { get; set; }

        [Display(Name = "Rezervuota datai")]
        [Required]
        public DateTime ReservedForDate { get; set; }

        [Display(Name = "Rezervacijos data")]
        [Required]
        public DateTime ReservedDate { get; set; }

        [Required]
        public int State { get; set; }
        
        [Display(Name = "Pastabos")]
        public string Comment { get; set; }

        // Relationships
        // User to reservation (0 to *)
        public int ReservedByUserId { get; set; }
        public User ReservedBy { get; set; }

        // Reservation to tableoccupancy (0.1 to *)
        public List<TableOccupancy> TableOccupancies { get; set; }
    }
}
