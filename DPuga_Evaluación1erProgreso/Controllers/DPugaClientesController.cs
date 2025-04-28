using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DPuga_Evaluación1erProgreso.Data;
using DPuga_Evaluación1erProgreso.Models;

namespace DPuga_Evaluación1erProgreso.Controllers
{
    
    public class DPugaClientesController : Controller
    {
        private readonly DPuga_Evaluación1erProgresoContext _context;

        public DPugaClientesController(DPuga_Evaluación1erProgresoContext context)
        {
            _context = context;
        }

        [HttpPost]

        // GET: DPugaClientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.DPugaClientes.ToListAsync());
        }

        // GET: DPugaClientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dPugaClientes = await _context.DPugaClientes
                .FirstOrDefaultAsync(m => m.IdCliente == id);
            if (dPugaClientes == null)
            {
                return NotFound();
            }

            return View(dPugaClientes);
        }

        // GET: DPugaClientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DPugaClientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCliente,Nombre,TieneMembresia,FechaNacimiento,MontoReserva")] DPugaClientes dPugaClientes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dPugaClientes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dPugaClientes);
        }

        // GET: DPugaClientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dPugaClientes = await _context.DPugaClientes.FindAsync(id);
            if (dPugaClientes == null)
            {
                return NotFound();
            }
            return View(dPugaClientes);
        }

        // POST: DPugaClientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCliente,Nombre,TieneMembresia,FechaNacimiento,MontoReserva")] DPugaClientes dPugaClientes)
        {
            if (id != dPugaClientes.IdCliente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dPugaClientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DPugaClientesExists(dPugaClientes.IdCliente))
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
            return View(dPugaClientes);
        }

        // GET: DPugaClientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dPugaClientes = await _context.DPugaClientes
                .FirstOrDefaultAsync(m => m.IdCliente == id);
            if (dPugaClientes == null)
            {
                return NotFound();
            }

            return View(dPugaClientes);
        }

        // POST: DPugaClientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dPugaClientes = await _context.DPugaClientes.FindAsync(id);
            if (dPugaClientes != null)
            {
                _context.DPugaClientes.Remove(dPugaClientes);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DPugaClientesExists(int id)
        {
            return _context.DPugaClientes.Any(e => e.IdCliente == id);
        }
    }
}
