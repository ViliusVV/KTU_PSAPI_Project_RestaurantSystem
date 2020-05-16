﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace PSAPIRestaurantSystem.Models
{
    public class MenuEntry
    {
        [Key]
        public int MenuEntryId { get; set; }

        [Required]
        [Display(Name = "Patiekalo pavadinimas")]
        public string MenuEntryName { get; set; }

        [Required]
        [Display(Name = "Kaina, €")]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Paskutinį kartą redaguota")]
        public DateTime Changed { get; set; }

        // Relationshps
        // Menu to menuentry (1 to *)
        [Display(Name = "Meniu kategorija")]
        public int MenuId { get; set; }
        [Display(Name = "Meniu kategorija")]
        public Menu Menu {get; set; }

        // Menuentry to orderedmeal (1 to *)
        public List<OrderedMeal> OrderedMeals { get; set; }
    }
}
