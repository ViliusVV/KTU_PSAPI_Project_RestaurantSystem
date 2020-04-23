using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        // Waiter to order (1 to *)
        [InverseProperty("ManagedBy")]
        public List<Order> Orders { get; set; }

        // Waiter to takeoutorder (1 to *)
        [InverseProperty("ManagedBy")]
        public List<TakeoutOrder> TakeoutOrders { get; set; }
    }
}
