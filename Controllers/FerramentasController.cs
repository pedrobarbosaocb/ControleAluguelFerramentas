using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProvaTecnica_ControleAlugueis.Data;
using ProvaTecnica_ControleAlugueis.Models;

namespace ProvaTecnica_ControleAlugueis.Controllers
{
    public class FerramentasController : Controller
    {
        private readonly ProvaTecnica_ControleAlugueisContext _context;

        public FerramentasController(ProvaTecnica_ControleAlugueisContext context)
        {
            _context = context;
        }

        // GET: Ferramentas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ferramenta.ToListAsync());
        }

        // GET: Ferramentas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ferramenta = await _context.Ferramenta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ferramenta == null)
            {
                return NotFound();
            }

            return View(ferramenta);
        }

        // GET: Ferramentas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ferramentas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao,EstMax,EstMin,EstAtu,PrecoDiaria")] Ferramenta ferramenta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ferramenta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ferramenta);
        }

        // GET: Ferramentas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ferramenta = await _context.Ferramenta.FindAsync(id);
            if (ferramenta == null)
            {
                return NotFound();
            }
            return View(ferramenta);
        }

        // POST: Ferramentas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao,EstMax,EstMin,EstAtu,PrecoDiaria")] Ferramenta ferramenta)
        {
            if (id != ferramenta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ferramenta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FerramentaExists(ferramenta.Id))
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
            return View(ferramenta);
        }

        // GET: Ferramentas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ferramenta = await _context.Ferramenta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ferramenta == null)
            {
                return NotFound();
            }

            return View(ferramenta);
        }

        // POST: Ferramentas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ferramenta = await _context.Ferramenta.FindAsync(id);
            _context.Ferramenta.Remove(ferramenta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FerramentaExists(int id)
        {
            return _context.Ferramenta.Any(e => e.Id == id);
        }
    }
}
