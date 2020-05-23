using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PSAPIRestaurantSystem.Models;

namespace PSAPIRestaurantSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RestaurantContext restaurantContext;
        //private readonly ISession session;
        public HomeController(ILogger<HomeController> logger/*, IHttpContextAccessor httpContextAccessor*/)
        {
            _logger = logger;
            //this.session = httpContextAccessor.HttpContext.Session;
            //session.SetString("role", "unregistered");
        }

        public IActionResult Index()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
