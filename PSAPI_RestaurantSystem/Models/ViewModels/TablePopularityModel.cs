using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace PSAPIRestaurantSystem.Models.ViewModels
{
    public class TablePopularityModel
    {
        public string TableId { get; set; }
        public int Count { get; set; }
    }
}
