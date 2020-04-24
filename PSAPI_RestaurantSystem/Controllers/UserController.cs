using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PSAPIRestaurantSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly RestaurantContext _context;

        public UserController(RestaurantContext context)
        {
            _context = context;
        }
    }
}