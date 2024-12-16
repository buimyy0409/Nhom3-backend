using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using wepapp.Data;
using wepapp.Models;

namespace wepapp.Controllers
{
    public class LoaiSPsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoaiSPsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LoaiSPs
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoaiSP.ToListAsync());
        }

        // GET: LoaiSPs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSP = await _context.LoaiSP
                .FirstOrDefaultAsync(m => m.MaLoai == id);
            if (loaiSP == null)
            {
                return NotFound();
            }

            return View(loaiSP);
        }

        // GET: LoaiSPs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LoaiSPs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TenLoai")] LoaiSP loaiSP)
        {
            var countLoaiSP = _context.LoaiSP.Count();
            StringBuilder sb = new StringBuilder();
            sb.Append("SP");
            sb.Append((countLoaiSP + 1).ToString("000000"));

            loaiSP.MaLoai = sb.ToString();

            _context.Add(loaiSP);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: LoaiSPs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSP = await _context.LoaiSP.FindAsync(id);
            if (loaiSP == null)
            {
                return NotFound();
            }
            return View(loaiSP);
        }

        // POST: LoaiSPs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaLoai,TenLoai,TrangThai")] LoaiSP loaiSP)
        {
            if (id != loaiSP.MaLoai)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiSP);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiSPExists(loaiSP.MaLoai))
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
            return View(loaiSP);
        }

        // GET: LoaiSPs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSP = await _context.LoaiSP
                .FirstOrDefaultAsync(m => m.MaLoai == id);
            if (loaiSP == null)
            {
                return NotFound();
            }

            return View(loaiSP);
        }

        // POST: LoaiSPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var loaiSP = await _context.LoaiSP.FindAsync(id);
            if (loaiSP != null)
            {
                _context.LoaiSP.Remove(loaiSP);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiSPExists(string id)
        {
            return _context.LoaiSP.Any(e => e.MaLoai == id);
        }
    }
}
