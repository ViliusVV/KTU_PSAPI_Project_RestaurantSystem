using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PSAPIRestaurantSystem.Models;

namespace PSAPIRestaurantSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly RestaurantContext _context;

        public AdminController(RestaurantContext context)
        {
            _context = context;
        }

        public IActionResult InsertMenuEntryForm()
        {
            var restaurantContext = _context.Menus.Include(m => m.MenuEntries);
            return View(restaurantContext.ToList());
        }

        // EDIT
        // Edit menu entry GET 
        public IActionResult EditMenuEntryForm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuEntry = _context.MenuEntries.Find(id);
            if (menuEntry == null)
            {
                return NotFound();
            }
            ViewData["MenuId"] = new SelectList(_context.Menus, "MenuId", "Title", menuEntry.MenuId);
            return View(menuEntry);
        }

        // Edit menu entry POST 
        [HttpPost]
        public IActionResult EditMenuEntryForm(int? id, MenuEntry menuEntry)
        {
            if (id != menuEntry.MenuEntryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var menu = _context.Menus.Find(menuEntry.MenuId);
                    menu.Changed = DateTime.Now;
                    menuEntry.Changed = DateTime.Now;
                    _context.Update(menuEntry);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MenuEntryExists(menuEntry.MenuEntryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/User/FoodMenu");
            }

            ViewData["MenuId"] = new SelectList(_context.Menus, "MenuId", "Title", menuEntry.MenuId);
            return View(menuEntry);
        }

        public IActionResult DeleteMenuEntryForm()
        {
            var restaurantContext = _context.Menus.Include(m => m.MenuEntries);
            return View(restaurantContext.ToList());
        }


        private bool MenuEntryExists(int id)
        {
            return _context.MenuEntries.Any(e => e.MenuEntryId == id);
        }
    }
}