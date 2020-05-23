using PSAPIRestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSAPIRestaurantSystem.Models.ViewModels
{
    public class AddOrderedMealViewModel
    {
        public int? OrderId { get; set; }
        public int? CurrentOrderedMealId { get; set; }
        public int? Quantity { get; set; }
        public string Comments { get; set; } = "";
        public DateTime OrderedForDate { get; set; }
        public List<OrderedMeal> OrderedMeals { get; set; }
    }
}
