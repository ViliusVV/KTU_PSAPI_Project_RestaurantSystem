using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PSAPIRestaurantSystem;
using PSAPIRestaurantSystem.Models;

namespace PSAPIRestaurantSystem.Controllers
{
    public class MenuEntriesController : Controller
    {
        private readonly RestaurantContext _context;

        public MenuEntriesController(RestaurantContext context)
        {
            _context = context;
        }

        // GET: MenuEntries
        public async Task<IActionResult> Index()
        {
            var restaurantContext = _context.MenuEntries.Include(m => m.Menu);
            return View(await restaurantContext.ToListAsync());
        }

        // GET: MenuEntries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuEntry = await _context.MenuEntries
                .Include(m => m.Menu)
                .FirstOrDefaultAsync(m => m.MenuEntryId == id);
            if (menuEntry == null)
            {
                return NotFound();
            }

            return View(menuEntry);
        }

        // GET: MenuEntries/Create
        public IActionResult Create()
        {
            ViewData["MenuId"] = new SelectList(_context.Menus, "MenuId", "Title");
            return View();
        }

        // POST: MenuEntries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MenuEntryId,MenuEntryName,Price,Changed,MenuId")] MenuEntry menuEntry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(menuEntry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MenuId"] = new SelectList(_context.Menus, "MenuId", "Title", menuEntry.MenuId);
            return View(menuEntry);
        }

        // GET: MenuEntries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuEntry = await _context.MenuEntries.FindAsync(id);
            if (menuEntry == null)
            {
                return NotFound();
            }
            ViewData["MenuId"] = new SelectList(_context.Menus, "MenuId", "Title", menuEntry.MenuId);
            return View(menuEntry);
        }

        // POST: MenuEntries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MenuEntryId,MenuEntryName,Price,Changed,MenuId")] MenuEntry menuEntry)
        {
            if (id != menuEntry.MenuEntryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(menuEntry);
                    await _context.SaveChangesAsync();
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
                return RedirectToAction(nameof(Index));
            }
            ViewData["MenuId"] = new SelectList(_context.Menus, "MenuId", "Title", menuEntry.MenuId);
            return View(menuEntry);
        }

        // GET: MenuEntries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuEntry = await _context.MenuEntries
                .Include(m => m.Menu)
                .FirstOrDefaultAsync(m => m.MenuEntryId == id);
            if (menuEntry == null)
            {
                return NotFound();
            }

            return View(menuEntry);
        }

        // POST: MenuEntries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var menuEntry = await _context.MenuEntries.FindAsync(id);
            _context.MenuEntries.Remove(menuEntry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MenuEntryExists(int id)
        {
            return _context.MenuEntries.Any(e => e.MenuEntryId == id);
        }
    }
}
