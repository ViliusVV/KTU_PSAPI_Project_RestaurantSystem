using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PSAPIRestaurantSystem.Models;
using PSAPIRestaurantSystem.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PSAPIRestaurantSystem.Controllers
{
    public class WaiterController : Controller
    {
        private readonly RestaurantContext _context;
        private readonly ILogger<WaiterController> _logger;
        public WaiterController(RestaurantContext context, ILogger<WaiterController> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult WaiterReservationPage()
        {
            var reserv = _context.Reservations.Include(r => r.ReservedBy).ThenInclude(p => p.Person).Include(t => t.TableOccupancies).ToList();
            return View(reserv);
        }
    }
}