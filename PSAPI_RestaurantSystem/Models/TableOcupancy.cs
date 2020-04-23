using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    public class TableOccupancy
    {
        public int TableOccupancyId { get; set; }


        // Relationships
        // Table to tableoccupancy (1 to *)
        public int TableId { get; set; }
        public Table Table { get; set; }

        // Order to tableoccupancy (1 to *)
        public int OrderId { get; set; }
        public Order Order { get; set; }

        // Reservation to tableoccupancy (0.1 to *)
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }
    }
}
