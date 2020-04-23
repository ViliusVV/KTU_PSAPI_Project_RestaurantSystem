﻿using System;
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
    }
}
