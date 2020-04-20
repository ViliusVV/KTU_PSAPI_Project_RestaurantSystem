using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPI_RestaurantSystem.Models
{
    public class Table
    {
        [Key]
        public int TableNum { get; set; }
        [Required]
        public int SeatCount { get; set; }


    }
}
