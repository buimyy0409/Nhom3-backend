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
    public class ChiTietDonHangsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChiTietDonHangsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ChiTietDonHangs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ChiTietDonHangs.Include(c => c.DonHang).Include(c => c.SP);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ChiTietDonHangs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietDonHang = await _context.ChiTietDonHangs
                .Include(c => c.DonHang)
                .Include(c => c.SP)
                .FirstOrDefaultAsync(m => m.MaSP == id);
            if (chiTietDonHang == null)
            {
                return NotFound();
            }

            return View(chiTietDonHang);
        }

        // GET: ChiTietDonHangs/Create
        public IActionResult Create()
        {
            ViewData["MaDonHang"] = new SelectList(_context.DonHang, "MaDonHang", "MaDonHang");
            ViewData["MaSP"] = new SelectList(_context.SanPham, "MaSP", "MaSP");
            return View();
        }

        // POST: ChiTietDonHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaDonHang,MaSP,SoLuong")] ChiTietDonHang chiTietDonHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietDonHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaDonHang"] = new SelectList(_context.DonHang, "MaDonHang", "MaDonHang", chiTietDonHang.MaDonHang);
            ViewData["MaSP"] = new SelectList(_context.SanPham, "MaSP", "MaSP", chiTietDonHang.MaSP);
            return View(chiTietDonHang);
        }

        // GET: ChiTietDonHangs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietDonHang = await _context.ChiTietDonHangs.FindAsync(id);
            if (chiTietDonHang == null)
            {
                return NotFound();
            }
            ViewData["MaDonHang"] = new SelectList(_context.DonHang, "MaDonHang", "MaDonHang", chiTietDonHang.MaDonHang);
            ViewData["MaSP"] = new SelectList(_context.SanPham, "MaSP", "MaSP", chiTietDonHang.MaSP);
            return View(chiTietDonHang);
        }

        // POST: ChiTietDonHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaDonHang,MaSP,SoLuong")] ChiTietDonHang chiTietDonHang)
        {
            if (id != chiTietDonHang.MaSP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietDonHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietDonHangExists(chiTietDonHang.MaSP))
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
            ViewData["MaDonHang"] = new SelectList(_context.DonHang, "MaDonHang", "MaDonHang", chiTietDonHang.MaDonHang);
            ViewData["MaSP"] = new SelectList(_context.SanPham, "MaSP", "MaSP", chiTietDonHang.MaSP);
            return View(chiTietDonHang);
        }

        // GET: ChiTietDonHangs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietDonHang = await _context.ChiTietDonHangs
                .Include(c => c.DonHang)
                .Include(c => c.SP)
                .FirstOrDefaultAsync(m => m.MaSP == id);
            if (chiTietDonHang == null)
            {
                return NotFound();
            }

            return View(chiTietDonHang);
        }

        // POST: ChiTietDonHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chiTietDonHang = await _context.ChiTietDonHangs.FindAsync(id);
            if (chiTietDonHang != null)
            {
                _context.ChiTietDonHangs.Remove(chiTietDonHang);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietDonHangExists(string id)
        {
            return _context.ChiTietDonHangs.Any(e => e.MaSP == id);
        }
    }
}
