﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }


        // Relationships
        // Person to user (1 to 1)
        public User User { get; set; }
    }
}
