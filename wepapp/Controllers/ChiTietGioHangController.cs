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
    public class ChiTietGioHangController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChiTietGioHangController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ChiTietGioHang
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ChiTietGioHangs.Include(c => c.GioHang).Include(c => c.SanPham);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ChiTietGioHang/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietGioHang = await _context.ChiTietGioHangs
                .Include(c => c.GioHang)
                .Include(c => c.SanPham)
                .FirstOrDefaultAsync(m => m.MaSP == id);
            if (chiTietGioHang == null)
            {
                return NotFound();
            }

            return View(chiTietGioHang);
        }

        // GET: ChiTietGioHang/Create
        public IActionResult Create()
        {
            ViewData["MaGioHang"] = new SelectList(_context.GioHang, "MaGioHang", "MaGioHang");
            ViewData["MaSP"] = new SelectList(_context.SanPham, "MaSP", "MaSP");
            return View();
        }

        // POST: ChiTietGioHang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaGioHang,MaSP,SoLuong")] ChiTietGioHang chiTietGioHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietGioHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaGioHang"] = new SelectList(_context.GioHang, "MaGioHang", "MaGioHang", chiTietGioHang.MaGioHang);
            ViewData["MaSP"] = new SelectList(_context.SanPham, "MaSP", "MaSP", chiTietGioHang.MaSP);
            return View(chiTietGioHang);
        }

        // GET: ChiTietGioHang/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietGioHang = await _context.ChiTietGioHangs.FindAsync(id);
            if (chiTietGioHang == null)
            {
                return NotFound();
            }
            ViewData["MaGioHang"] = new SelectList(_context.GioHang, "MaGioHang", "MaGioHang", chiTietGioHang.MaGioHang);
            ViewData["MaSP"] = new SelectList(_context.SanPham, "MaSP", "MaSP", chiTietGioHang.MaSP);
            return View(chiTietGioHang);
        }

        // POST: ChiTietGioHang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaGioHang,MaSP,SoLuong")] ChiTietGioHang chiTietGioHang)
        {
            if (id != chiTietGioHang.MaSP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietGioHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietGioHangExists(chiTietGioHang.MaSP))
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
            ViewData["MaGioHang"] = new SelectList(_context.GioHang, "MaGioHang", "MaGioHang", chiTietGioHang.MaGioHang);
            ViewData["MaSP"] = new SelectList(_context.SanPham, "MaSP", "MaSP", chiTietGioHang.MaSP);
            return View(chiTietGioHang);
        }

        // GET: ChiTietGioHang/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietGioHang = await _context.ChiTietGioHangs
                .Include(c => c.GioHang)
                .Include(c => c.SanPham)
                .FirstOrDefaultAsync(m => m.MaSP == id);
            if (chiTietGioHang == null)
            {
                return NotFound();
            }

            return View(chiTietGioHang);
        }

        // POST: ChiTietGioHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chiTietGioHang = await _context.ChiTietGioHangs.FindAsync(id);
            if (chiTietGioHang != null)
            {
                _context.ChiTietGioHangs.Remove(chiTietGioHang);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietGioHangExists(string id)
        {
            return _context.ChiTietGioHangs.Any(e => e.MaSP == id);
        }
    }
}
