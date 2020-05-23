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

        // open orders page

        public IActionResult OrderList()
        {
            var orders = _context.Orders
                .Include(t => t.TableOccupancies)
                .Include(o => o.OrderedMeals)
                .Include(m => m.ManagedBy)
                    .ThenInclude(e => e.Employee)
                        .ThenInclude(u => u.User)
                            .ThenInclude(p => p.Person).ToList();

            foreach (var order in orders)
            {
                if(order.State == (int)OrderState.Created || order.State == (int)OrderState.CreatedReservation)
                {
                    if(order.OrderedMeals.Count > 0)
                        order.Duration = (int)(DateTime.Now - order.OrderDate).TotalMinutes;
                }
                order.Price = order.OrderedMeals.Sum(s => s.Price * s.Quantity);
            }
            return View(orders);
        }

        public IActionResult OrderCreationForm()
        {
            ViewData["TableNum"] = new SelectList(_context.Tables, "TableNum", "TableNum");
            return View();
        }

        [HttpPost]
        public IActionResult OrderCreationFormAdd(OrderCreateViewModel model)
        {
            if (model.Tables == null) model.Tables = new List<Table>();
            var table = _context.Tables.Find(model.CurrentTable);
            model.Tables.Add(table);
            model.CurrentTable = null;
            ViewData["TableNum"] = new SelectList(_context.Tables, "TableNum", "TableNum");
            return View("OrderCreationForm", model);
        }


        [HttpPost]
        public IActionResult OrderCreationForm(OrderCreateViewModel model)
        {
            var usrID = HttpContext.Session.GetInt32("userID");
            var waiterId = _context.Users.Where(w => w.UserId == (int)usrID).Include(e => e.Employee).ThenInclude(w => w.Waiter).FirstOrDefault().Employee.Waiter.WaiterId;
            var table = _context.Tables.Find(model.CurrentTable);
            model.Tables.Add(table);
            var order = new Order { Duration = 0, ManagedByWaiterId = waiterId, OrderDate = DateTime.Now, State = (int)OrderState.Created, Price = 0.0 };
            _context.Add(order);
            _context.SaveChanges();

            foreach(var t in model.Tables)
            {
                var to = new TableOccupancy { OrderId = order.OrderId, TableId = t.TableNum };
                _context.Add(to);
            }
            _context.SaveChanges();
            return RedirectToAction("OrderList");
        }
    }
}