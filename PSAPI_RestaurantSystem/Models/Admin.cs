using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required]
        public string WorkEmail { get; set; }


        // Relationships
        // Employee to admin (1 to 1)
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        // Admin to employee (1 to *)
        [InverseProperty("RegisteredBy")]
        public List<Employee> RegisteredEmployees { get; set; }
    }
}
