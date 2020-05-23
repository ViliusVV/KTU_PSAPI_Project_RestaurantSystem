using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models.ViewModels
{
    public class OrderCreateViewModel
    {
        public int? CurrentTable { get; set; }
        public List<Table> Tables { get; set; }
    }
}
