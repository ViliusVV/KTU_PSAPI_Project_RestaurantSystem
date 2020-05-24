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
    public class UserController : Controller
    {
        private readonly RestaurantContext _context;
        private readonly ILogger<UserController> _logger;

        public UserController(RestaurantContext context, ILogger<UserController> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult FoodMenu()
        {
            var restaurantContext = _context.Menus.Include(m => m.MenuEntries);
            return View(restaurantContext.ToList());
        }
        public IActionResult LoginForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginForm(LoginViewModel model)
        {
            _logger.LogDebug(model.LoginName);
            var usr = _context.Users.Where(u => u.Email == model.LoginName)
                .Include(e => e.Employee)
                    .ThenInclude(a => a.Admin)
                .Include(e => e.Employee)
                    .ThenInclude(w => w.Waiter)
                .Include(p => p.Person)
                .FirstOrDefault();

            HttpContext.Session.SetString("role", "admin");
            if (usr == null)
            {
                return View();
            }
            else
            {
                HttpContext.Session.SetInt32("userID", usr.UserId);
                HttpContext.Session.SetString("name", usr.Person.Name);
                HttpContext.Session.SetString("surname", usr.Person.Surname);
            }
            if (usr.Employee != null)
            {
                if (usr.Employee.Waiter != null)
                {
                    HttpContext.Session.SetString("role", "waiter");

                }

                else if (usr.Employee.Admin != null)
                {
                    HttpContext.Session.SetString("role", "admin");
                }
            }
            else
            {
                HttpContext.Session.SetString("role", "user");
            }

            return Redirect("/");
        }

        // Open generic review list page
        public IActionResult ReviewsPage()
        {
            var reviews = _context.Reviews.Include(u => u.User).ThenInclude(p => p.Person);
            return View(reviews.ToList());
        }

        // Edit/Create review
        public IActionResult EditableReviewsPage()
        {
            var usrID = HttpContext.Session.GetInt32("userID");

            var review = _context.Reviews.Where(r => r.UserId == usrID).FirstOrDefault();

            if (review == null)
            {
                return RedirectToAction("ReviewInsertForm");
            }
            else
            {
                return RedirectToAction("ReviewEditForm", new { id = usrID } );
            }
            return RedirectToAction("ReviewsPage");
        }

        // Edit review form GET

        public IActionResult ReviewEditForm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reviewEntry = _context.Reviews.Where(r => r.UserId == id).FirstOrDefault();
            if (reviewEntry == null)
            {
                return NotFound();
            }
            ViewData["Rating"] = new SelectList(Review.digits, "Value", "Text");
            return View(reviewEntry);
        }

        // Insert review form GET

        public IActionResult ReviewInsertForm()
        {
            ViewData["Rating"] = new SelectList(Review.digits, "Value", "Text");
            return View();
        }
        
        // Insert review form POST

        [HttpPost]
        public IActionResult ReviewInsertForm(Review rev)
        {
            ModelState.Remove("ReviewId");
            if (ModelState.IsValid)
            {
                rev.UserId = (int)HttpContext.Session.GetInt32("userID");
                rev.ReviewDate = DateTime.Now;
                _context.Add(rev);
                _context.SaveChanges();

                return Redirect("/User/ReviewsPage");
            }
            ViewData["Rating"] = new SelectList(Review.digits, "Value", "Text");
            return View(rev);
        }

        // Edit review form POST
        [HttpPost]
        public IActionResult ReviewEditForm(int? id, Review reviewEntry)
        {
            if (ModelState.IsValid)
            {
                reviewEntry.UserId = (int)HttpContext.Session.GetInt32("userID");
                reviewEntry.ReviewDate = DateTime.Now;
                _context.Update(reviewEntry);
                _context.SaveChanges();

                return Redirect("/User/ReviewsPage");
            }

            ViewData["Rating"] = new SelectList(Review.digits, "Value", "Text");
            return View(reviewEntry);
        }

        // User logout

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return Redirect("/");
        }

        // Open reservation page

        public IActionResult ReservationPage()
        {
            var usrID = HttpContext.Session.GetInt32("userID");
            var reservation = _context.Reservations.Where(r => r.ReservedByUserId == usrID).Include(t => t.TableOccupancies);
            return View(reservation.ToList());
        }

        public IActionResult ReservationForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ReservationForm(Reservation reserv)
        {
            ModelState.Remove("ReservationId");
            if(ModelState.IsValid)
            {
                reserv.ReservedByUserId = (int)HttpContext.Session.GetInt32("userID");
                reserv.ReservedDate = DateTime.Now;
                reserv.State = (int)ReservationState.Active;
                _context.Add(reserv);
                _context.SaveChanges();
                CreateOrderPriorityQueue(reserv);
                return Redirect("/User/ReservationPage");
            }
            return View(reserv);
        }

        public void CreateOrderPriorityQueue(Reservation rev)
        {
            var order = new Order { OrderDate = DateTime.Now, Price = 0.0, Duration = 0, State = (int)OrderState.CreatedReservation};
            _context.Add(order);
            _context.SaveChanges();
            var tables = _context.Tables.ToList();
            var count = rev.PeopleCount;
            var idList = new List<int>();
            var index = 0;
            while (count > 0)
            {
                idList.Add(tables[index].TableNum);
                count = count - tables[index].SeatCount;
                index++;
            }
            foreach (int id in idList)
            {
                var temp = new TableOccupancy { OrderId = order.OrderId, ReservationId = rev.ReservationId, TableId = id };
                _context.Add(temp);
            }
            _context.SaveChanges();
        }
        public IActionResult TakeoutOrdersPage()
        {
            var usrID = HttpContext.Session.GetInt32("userID");
            var takeoutOrder = _context.TakeoutOrders.Include(t => t.OrderedMeals).ThenInclude(m => m.MenuEntry).Where(o => o.OrderedBy.UserId == usrID);

            foreach (var meal in takeoutOrder)
            {
                meal.Price = meal.OrderedMeals.Sum(s => s.Price * s.Quantity);
            }

            return View(takeoutOrder.ToList());
        }

        // AddOrderedMeals for order GET
        public IActionResult TakeoutOrderForm()
        {
            var model = new AddOrderedMealViewModel();
            model.OrderedMeals = new List<OrderedMeal>();
            model.OrderedForDate = DateTime.Now;
            var menuEntries = _context.MenuEntries.Include(m => m.Menu).ToList();
            var selectList = new List<SelectListItem>();

            foreach (var entry in menuEntries)
            {
                selectList.Add(new SelectListItem()
                {
                    Value = entry.MenuEntryId.ToString(),
                    Text = entry.MenuEntryName,
                }); ;
            }

            ViewData["Menu"] = new SelectList(selectList, "Value", "Text");
            return View(model);
        }


        [HttpPost]
        public IActionResult TakeoutOrderFormAdd(AddOrderedMealViewModel model)
        {
            if (model.OrderedMeals == null) model.OrderedMeals = new List<OrderedMeal>();

            var meal = new OrderedMeal
            {
                MenuEntryId = (int)model.CurrentOrderedMealId,
                Quantity = (int)model.Quantity,
                Comment = model.Comments,
                Price = _context.MenuEntries.Find(model.CurrentOrderedMealId).Price
            };
            model.OrderedMeals.Add(meal);
            for (int i = 0; i < model.OrderedMeals.Count; i++)
            {
                model.OrderedMeals[i].MenuEntry = _context.MenuEntries.Find(model.OrderedMeals[i].MenuEntryId);
            }
            model.CurrentOrderedMealId = null;
            model.Quantity = null;
            model.Comments = null;


            var menuEntries = _context.MenuEntries.Include(m => m.Menu).ToList();
            var selectList = new List<SelectListItem>();
            foreach (var entry in menuEntries)
            {
                selectList.Add(new SelectListItem()
                {
                    Value = entry.MenuEntryId.ToString(),
                    Text = entry.MenuEntryName,
                }); ;
            }
            ViewData["Menu"] = new SelectList(selectList, "Value", "Text");
            return View("TakeoutOrderForm", model);
        }


        [HttpPost]
        public IActionResult TakeoutOrderForm(AddOrderedMealViewModel model)
        {
            if (model.OrderedMeals == null) model.OrderedMeals = new List<OrderedMeal>();

            var meal = new OrderedMeal
            {
                MenuEntryId = (int)model.CurrentOrderedMealId,
                Quantity = (int)model.Quantity,
                Comment = model.Comments,
                Price = _context.MenuEntries.Find(model.CurrentOrderedMealId).Price
            };
            model.OrderedMeals.Add(meal);

            CreateTakeoutPriorityOrderQueue(model);


            var menuEntries = _context.MenuEntries.Include(m => m.Menu).ToList();
            var selectList = new List<SelectListItem>();
            foreach (var entry in menuEntries)
            {
                selectList.Add(new SelectListItem()
                {
                    Value = entry.MenuEntryId.ToString(),
                    Text = entry.MenuEntryName,
                }); ;
            }
            ViewData["Menu"] = new SelectList(selectList, "Value", "Text");
            return Redirect("/User/TakeoutOrdersPage");
        }

        public void CreateTakeoutPriorityOrderQueue(AddOrderedMealViewModel model)
        {
            var usrID = HttpContext.Session.GetInt32("userID");

            var users = _context.Users.Include(t => t.TakeoutOrders).Include(r => r.Reservations).ToList();
            foreach(var user in users)
            {
                user.LoyalityPoints = user.Reservations.Where(r => r.State != (int)OrderState.Canceled).ToList().Count;
                user.LoyalityPoints -= user.Reservations.Where(r => r.State == (int)OrderState.Canceled).ToList().Count;
                user.LoyalityPoints += user.TakeoutOrders.Where(r => r.State != (int)OrderState.Canceled).ToList().Count;
                user.LoyalityPoints -= user.TakeoutOrders.Where(r => r.State == (int)OrderState.Canceled).ToList().Count;
            }

            var takeout = new TakeoutOrder
            {
                OrderedByUserId = (int)usrID,
                OrderDate = DateTime.Now,
                OrderedForDate = (DateTime)model.OrderedForDate,
                Price = 0,
                State = (int)OrderState.Created,
                ManagedByWaiterId = 1
            };

            var minDate = takeout.OrderedForDate.AddMinutes(-5);
            var maxDate = takeout.OrderedForDate.AddMinutes(5);
            var beforeTake = _context.TakeoutOrders.Where(d => DateTime.Compare(minDate, d.OrderedForDate) <= 0);
            var afterTake = beforeTake.Where(d => DateTime.Compare(maxDate, d.OrderedForDate) >= 0).Include(u => u.OrderedBy);
            var overlaped = afterTake.FirstOrDefault();
            bool overlap = overlaped != null ? true : false;
            int currentUserPoints = users.Where(l => l.UserId == (int)usrID).FirstOrDefault().LoyalityPoints;
            int overlapUserPoints = overlap ? overlaped.OrderedBy.LoyalityPoints : 0;
            if(overlap)
            {
                if(overlapUserPoints >= currentUserPoints)
                {
                    takeout.State = (int)OrderState.Canceled;
                    _context.Add(takeout);
                    _context.SaveChanges();

                    foreach (var m in model.OrderedMeals)
                    {
                        var om = new OrderedMeal
                        {
                            InTakeoutTakeoutOrderId = takeout.TakeoutOrderId,
                            MenuEntryId = m.MenuEntryId,
                            Quantity = m.Quantity,
                            Comment = m.Comment,
                            Price = m.Price
                        };
                        _context.Add(om);
                    }
                }
                else
                {
                    overlaped.State = (int)OrderState.Canceled;
                    _context.Update(overlaped);
                    _context.Add(takeout);
                    _context.SaveChanges();

                    foreach (var m in model.OrderedMeals)
                    {
                        var om = new OrderedMeal
                        {
                            InTakeoutTakeoutOrderId = takeout.TakeoutOrderId,
                            MenuEntryId = m.MenuEntryId,
                            Quantity = m.Quantity,
                            Comment = m.Comment,
                            Price = m.Price
                        };
                        _context.Add(om);
                    }
                }
            }
            else // No overlap detected
            {
                _context.Add(takeout);
                _context.SaveChanges();

                foreach (var m in model.OrderedMeals)
                {
                    var om = new OrderedMeal
                    {
                        InTakeoutTakeoutOrderId = takeout.TakeoutOrderId,
                        MenuEntryId = m.MenuEntryId,
                        Quantity = m.Quantity,
                        Comment = m.Comment,
                        Price = m.Price
                    };
                    _context.Add(om);
                }
            }
  


            _context.SaveChanges();
        }
    }
}