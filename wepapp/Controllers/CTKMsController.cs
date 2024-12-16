using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using wepapp.Data;
using wepapp.Models;

namespace wepapp.Controllers
{
    public class CTKMsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CTKMsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CTKMs
        public async Task<IActionResult> Index()
        {
            return View(await _context.CTKM.ToListAsync());
        }

        // GET: CTKMs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cTKM = await _context.CTKM
                .FirstOrDefaultAsync(m => m.MaCTKM == id);
            if (cTKM == null)
            {
                return NotFound();
            }

            return View(cTKM);
        }

        // GET: CTKMs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CTKMs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaCTKM,TenCTKM,NoiDung,NgayBatDau,NgayKetThuc,LoaiCTKM,SoTienMuaToiThieu,SoTienDuocGiam")] CTKM cTKM)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cTKM);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cTKM);
        }

        // GET: CTKMs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cTKM = await _context.CTKM.FindAsync(id);
            if (cTKM == null)
            {
                return NotFound();
            }
            return View(cTKM);
        }

        // POST: CTKMs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaCTKM,TenCTKM,NoiDung,NgayBatDau,NgayKetThuc,LoaiCTKM,SoTienMuaToiThieu,SoTienDuocGiam")] CTKM cTKM)
        {
            if (id != cTKM.MaCTKM)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cTKM);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CTKMExists(cTKM.MaCTKM))
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
            return View(cTKM);
        }

        // GET: CTKMs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cTKM = await _context.CTKM
                .FirstOrDefaultAsync(m => m.MaCTKM == id);
            if (cTKM == null)
            {
                return NotFound();
            }

            return View(cTKM);
        }

        // POST: CTKMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var cTKM = await _context.CTKM.FindAsync(id);
            if (cTKM != null)
            {
                _context.CTKM.Remove(cTKM);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CTKMExists(string id)
        {
            return _context.CTKM.Any(e => e.MaCTKM == id);
        }
    }
}
