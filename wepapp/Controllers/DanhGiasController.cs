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
    public class DanhGiasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DanhGiasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DanhGias
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DanhGia.Include(d => d.KhachHang).Include(d => d.SanPham);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DanhGias/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var danhGia = await _context.DanhGia
                .Include(d => d.KhachHang)
                .Include(d => d.SanPham)
                .FirstOrDefaultAsync(m => m.MaDanhGia == id);
            if (danhGia == null)
            {
                return NotFound();
            }

            return View(danhGia);
        }

        // GET: DanhGias/Create
        public IActionResult Create()
        {
            ViewData["MaKH"] = new SelectList(_context.KhachHang, "MaKH", "MaKH");
            ViewData["MaSP"] = new SelectList(_context.SanPham, "MaSP", "MaSP");
            return View();
        }

        // POST: DanhGias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaDanhGia,MaKH,MaSP,NoiDung,Hinh")] DanhGia danhGia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(danhGia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaKH"] = new SelectList(_context.KhachHang, "MaKH", "MaKH", danhGia.MaKH);
            ViewData["MaSP"] = new SelectList(_context.SanPham, "MaSP", "MaSP", danhGia.MaSP);
            return View(danhGia);
        }

        // GET: DanhGias/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var danhGia = await _context.DanhGia.FindAsync(id);
            if (danhGia == null)
            {
                return NotFound();
            }
            ViewData["MaKH"] = new SelectList(_context.KhachHang, "MaKH", "MaKH", danhGia.MaKH);
            ViewData["MaSP"] = new SelectList(_context.SanPham, "MaSP", "MaSP", danhGia.MaSP);
            return View(danhGia);
        }

        // POST: DanhGias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaDanhGia,MaKH,MaSP,NoiDung,Hinh")] DanhGia danhGia)
        {
            if (id != danhGia.MaDanhGia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(danhGia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DanhGiaExists(danhGia.MaDanhGia))
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
            ViewData["MaKH"] = new SelectList(_context.KhachHang, "MaKH", "MaKH", danhGia.MaKH);
            ViewData["MaSP"] = new SelectList(_context.SanPham, "MaSP", "MaSP", danhGia.MaSP);
            return View(danhGia);
        }

        // GET: DanhGias/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var danhGia = await _context.DanhGia
                .Include(d => d.KhachHang)
                .Include(d => d.SanPham)
                .FirstOrDefaultAsync(m => m.MaDanhGia == id);
            if (danhGia == null)
            {
                return NotFound();
            }

            return View(danhGia);
        }

        // POST: DanhGias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var danhGia = await _context.DanhGia.FindAsync(id);
            if (danhGia != null)
            {
                _context.DanhGia.Remove(danhGia);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DanhGiaExists(string id)
        {
            return _context.DanhGia.Any(e => e.MaDanhGia == id);
        }
    }
}
