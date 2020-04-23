﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    public class Table
    {
        [Key]
        public int TableNum { get; set; }

        [Required]
        public int SeatCount { get; set; }


        // Relationships
        // Table to tableoccupancy (1 to *)
        public List<TableOccupancy> TableOccupancies { get; set; }
    }
}
