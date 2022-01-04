using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using web.Data;
using web.Models;

namespace web.Controllers
{
    public class NepremicnineController : Controller
    {
        private readonly NepremicnineContext _context;

        public NepremicnineController(NepremicnineContext context)
        {
            _context = context;
        }

        // GET: strankas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nepremicnine.ToListAsync());
        }

        // GET: strankas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stranka = await _context.Nepremicnine
                .FirstOrDefaultAsync(m => m.ID == id);
            if (stranka == null)
            {
                return NotFound();
            }

            return View(stranka);
        }

        // GET: strankas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: strankas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Naslov,AgentID")] Nepremicnina stranka)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stranka);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stranka);
        }

        // GET: strankas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stranka = await _context.Nepremicnine.FindAsync(id);
            if (stranka == null)
            {
                return NotFound();
            }
            return View(stranka);
        }

        // POST: strankas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Naslov,AgentID")] Nepremicnina stranka)
        {
            if (id != stranka.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stranka);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!strankaExists(stranka.ID))
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
            return View(stranka);
        }

        // GET: strankas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stranka = await _context.Nepremicnine
                .FirstOrDefaultAsync(m => m.ID == id);
            if (stranka == null)
            {
                return NotFound();
            }

            return View(stranka);
        }

        // POST: strankas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stranka = await _context.Nepremicnine.FindAsync(id);
            _context.Nepremicnine.Remove(stranka);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool strankaExists(int id)
        {
            return _context.Nepremicnine.Any(e => e.ID == id);
        }
    }
}
