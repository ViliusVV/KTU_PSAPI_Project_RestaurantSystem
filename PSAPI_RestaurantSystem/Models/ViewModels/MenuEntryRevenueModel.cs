using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace PSAPIRestaurantSystem.Models.ViewModels
{
    public class MenuEntryRevenuModel
    {
        public string MenuEntryName { get; set; }
        public int Revenue { get; set; }
        public int Counts { get; set; }
    }
}
