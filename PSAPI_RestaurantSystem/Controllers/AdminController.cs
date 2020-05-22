using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PSAPIRestaurantSystem.Models;
using PSAPIRestaurantSystem.Models.ViewModels;

namespace PSAPIRestaurantSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly RestaurantContext _context;

        public AdminController(RestaurantContext context)
        {
            _context = context;
        }


        // ========= INSERT ================
        // Insert menu entry GET
        public IActionResult InsertMenuEntryForm()
        {
            ViewData["MenuId"] = new SelectList(_context.Menus, "MenuId", "Title");
            return View();
        }

        // Insert menu entry POST
        [HttpPost]
        public IActionResult InsertMenuEntryForm(MenuEntry menuEntry)
        {
            ModelState.Remove("MenuEntryId");
            if (ModelState.IsValid)
            {
                var menu = _context.Menus.Find(menuEntry.MenuId);
                menu.Changed = DateTime.Now;
                menuEntry.Changed = DateTime.Now;
                _context.Add(menuEntry);
                _context.SaveChanges();

                return Redirect("/User/FoodMenu");
            }
            ViewData["MenuId"] = new SelectList(_context.Menus, "MenuId", "Title", menuEntry.MenuId);
            return View(menuEntry);
        }


        // ========== EDIT =================
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


        // =========== DELETE ============
        // Delete menu entry GET
        public IActionResult DeleteMenuEntryForm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuEntry = _context.MenuEntries.Include(m => m.Menu).FirstOrDefault(m => m.MenuEntryId == id);

            if (menuEntry == null)
            {
                return NotFound();
            }

            return View(menuEntry);
        }

        // Delete menu entry POST
        [HttpPost]
        public IActionResult DeleteMenuEntryForm(int id)
        {
            var menuEntry = _context.MenuEntries.Find(id);

            var menu = _context.Menus.Find(menuEntry.MenuId);
            menu.Changed = DateTime.Now;

            _context.MenuEntries.Remove(menuEntry);
            _context.Menus.Update(menu);
            _context.SaveChanges();
            return Redirect("/User/FoodMenu");
        }


        private bool MenuEntryExists(int id)
        {
            return _context.MenuEntries.Any(e => e.MenuEntryId == id);
        }


        // Char order page GET
        public IActionResult OrderChartPage()
        {
            return View();
        }

        // Return order chart data json GET
        public JsonResult GetChartData()
        {
            var menuEntriesRevenue = new List<MenuEntryRevenuModel>();
            var tablePopularity = new List<TablePopularityModel>();

            var menuEntries = _context.MenuEntries.Include(m => m.OrderedMeals).ToList();
            var tables = _context.Tables.Include(t => t.TableOccupancies);


            foreach(var entry in menuEntries)
            {
                menuEntriesRevenue.Add(new MenuEntryRevenuModel
                {
                    MenuEntryName = entry.MenuEntryName,
                    Revenue = entry.OrderedMeals.Sum(s => (int)(s.Quantity * s.Price)),
                    Counts = entry.OrderedMeals.Sum(s => s.Quantity)
                });
            }

            foreach(var table in tables)
            {
                tablePopularity.Add(new TablePopularityModel
                {
                    TableId = "Nr. " + table.TableNum.ToString(),
                    Count = table.TableOccupancies.Count
                });
            }


            return Json(new {menu = menuEntriesRevenue, tables = tablePopularity});
        }

    }
}