using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [Required]
        public int PeopleCount { get; set; }

        [Required]
        public DateTime ReservedForDate { get; set; }

        [Required]
        public DateTime ReservedDate { get; set; }

        [Required]
        public int State { get; set; }

        public string Comment { get; set; }

        // Relationships
        // User to reservation (0 to *)
        public int ReservedByUserId { get; set; }
        public User ReservedBy { get; set; }

        // Reservation to tableoccupancy (0.1 to *)
        public List<TableOccupancy> TableOccupancies { get; set; }
    }
}
