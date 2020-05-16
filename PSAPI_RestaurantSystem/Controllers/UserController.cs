﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PSAPIRestaurantSystem.Models;
using PSAPIRestaurantSystem.Models.ViewModels;

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
            var usr = _context.Users.Where(u => u.Email == model.LoginName).Include(e => e.Employee).ThenInclude(a => a.Admin).Include(e => e.Employee).ThenInclude(w => w.Waiter).FirstOrDefault();

            if(usr.Employee != null)
            {
                if (usr.Employee.Waiter != null)
                {

                }

                if (usr.Employee.Admin != null)
                {

                }
            }

            return View();
        }

        // Open generic review list page
        public IActionResult ReviewsPage()
        {
            var reviews = _context.Reviews.Include(u => u.User).ThenInclude(p => p.Person);
            return View(reviews.ToList());
        }
    }
}