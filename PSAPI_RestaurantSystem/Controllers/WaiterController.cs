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

        // Open orders page
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

        // Order creation for GET
        public IActionResult OrderCreationForm()
        {
            ViewData["TableNum"] = new SelectList(_context.Tables, "TableNum", "TableNum");
            return View();
        }

        // Order creation form, add table to list and returns page with new list POST
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


        // Order creation form POST
        [HttpPost]
        public IActionResult OrderCreationForm(OrderCreateViewModel model)
        {
            if (model.Tables == null) model.Tables = new List<Table>();
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

        // Order page (Details view) GET
        public IActionResult OrderPage(int? id)
        { 
            if (id == null)
            {
                return NotFound();
            }

            var order = _context.Orders
                .Where(o => o.OrderId == id)
                .Include(m => m.OrderedMeals)
                    .ThenInclude(e => e.MenuEntry)
                .Include(w => w.ManagedBy)
                    .ThenInclude(e => e.Employee)
                        .ThenInclude(u => u.User)
                .Include(t => t.TableOccupancies)
                .FirstOrDefault();

            if(order == null)
            {
                return NotFound();
            }
                
            return View(order);
        }

        // AddOrderedMeals for order GET
        public IActionResult AddOrderedMeal(int? id)
        {
            return View();
        }

        public IActionResult OrderDeleteForm(int id)
        {
            var order = _context.Orders.Find(id);
            return View(order);
        }

        // Order deletion form POST
        [HttpPost]
        public IActionResult OrderDeleteForm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = _context.Orders.Find(id);
            
            if(order == null)
            {
                return NotFound();
            }

            order.State = (int)OrderState.Canceled;
            _context.Update(order);
            _context.SaveChanges();

            return RedirectToAction("OrderList");
        }
    }
}