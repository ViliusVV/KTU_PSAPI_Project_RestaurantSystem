using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    public class Waiter
    {
        [Key]
        public int WaiterId { get; set; }

        [Required] 
        public double Tips { get; set; }


        // Relationships
        // Employee to waiter (1 to 1)
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
