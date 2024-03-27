using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Euneo.Data;
using Euneo.Models;

namespace Euneo.Controllers
{
    public class ConversationTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConversationTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ConversationTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ConversationType.ToListAsync());
        }

        // GET: ConversationTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conversationType = await _context.ConversationType
                .FirstOrDefaultAsync(m => m.ConversationTypeId == id);
            if (conversationType == null)
            {
                return NotFound();
            }

            return View(conversationType);
        }

        // GET: ConversationTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ConversationTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConversationTypeId,ConversationTypeName")] ConversationType conversationType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(conversationType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(conversationType);
        }

        // GET: ConversationTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conversationType = await _context.ConversationType.FindAsync(id);
            if (conversationType == null)
            {
                return NotFound();
            }
            return View(conversationType);
        }

        // POST: ConversationTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ConversationTypeId,ConversationTypeName")] ConversationType conversationType)
        {
            if (id != conversationType.ConversationTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(conversationType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConversationTypeExists(conversationType.ConversationTypeId))
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
            return View(conversationType);
        }

        // GET: ConversationTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conversationType = await _context.ConversationType
                .FirstOrDefaultAsync(m => m.ConversationTypeId == id);
            if (conversationType == null)
            {
                return NotFound();
            }

            return View(conversationType);
        }

        // POST: ConversationTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // TODO reescribir el borrado para detectar los fallos cuando trata de borrar una clave foranea "departmentcontroller.cs" y enlace marcadores Firefox.
            var conversationType = await _context.ConversationType.FindAsync(id);
            if (conversationType != null)
            {
                _context.ConversationType.Remove(conversationType);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConversationTypeExists(int id)
        {
            return _context.ConversationType.Any(e => e.ConversationTypeId == id);
        }
    }
}
