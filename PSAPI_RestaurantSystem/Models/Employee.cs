using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public DateTime BeganWork { get; set; }

        public DateTime EndedWork { get; set; }

        [Required]
        public int EmployeeState { get; set; }

        [Required]
        public int Salary { get; set; }


        // Relationships
        // Person to user (1 to 1)
        public int UserId { get; set; }
        public User User { get; set; }

        // Employee to admin (1 to 1)
        public Admin Admin { get; set; }
        // Employee to waiter (1 to 1)
        public Waiter Waiter { get; set; }

        // Admin to employee (1 to *)
        public int RegisteredByAdminId { get; set; }
        public Admin RegisteredBy { get; set; }
    }   
}
