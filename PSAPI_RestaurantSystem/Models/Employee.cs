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
        public string EmployeeCode { get; set; }

        [Required]
        public DateTime BeganWork { get; set; }

        public DateTime EndedWork { get; set; }

        [Required]
        public int EmployeeState { get; set; }

        [Required]
        public int Salary { get; set; }
    }
}
