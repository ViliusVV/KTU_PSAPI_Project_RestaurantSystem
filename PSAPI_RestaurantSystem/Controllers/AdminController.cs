using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PSAPIRestaurantSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly RestaurantContext _context;

        public AdminController(RestaurantContext context)
        {
            _context = context;
        }
    }
}