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
    public class AlbumSPsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlbumSPsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AlbumSPs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Albums.Include(a => a.SP);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: AlbumSPs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albumSP = await _context.Albums
                .Include(a => a.SP)
                .FirstOrDefaultAsync(m => m.MaAlbum == id);
            if (albumSP == null)
            {
                return NotFound();
            }

            return View(albumSP);
        }

        // GET: AlbumSPs/Create
        public IActionResult Create()
        {
            ViewData["MaSP"] = new SelectList(_context.SanPham, "MaSP", "MaSP");
            return View();
        }

        // POST: AlbumSPs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaAlbum,MaSP,Hinh")] AlbumSP albumSP)
        {
            if (ModelState.IsValid)
            {
                _context.Add(albumSP);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaSP"] = new SelectList(_context.SanPham, "MaSP", "MaSP", albumSP.MaSP);
            return View(albumSP);
        }

        // GET: AlbumSPs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albumSP = await _context.Albums.FindAsync(id);
            if (albumSP == null)
            {
                return NotFound();
            }
            ViewData["MaSP"] = new SelectList(_context.SanPham, "MaSP", "MaSP", albumSP.MaSP);
            return View(albumSP);
        }

        // POST: AlbumSPs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaAlbum,MaSP,Hinh")] AlbumSP albumSP)
        {
            if (id != albumSP.MaAlbum)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(albumSP);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlbumSPExists(albumSP.MaAlbum))
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
            ViewData["MaSP"] = new SelectList(_context.SanPham, "MaSP", "MaSP", albumSP.MaSP);
            return View(albumSP);
        }

        // GET: AlbumSPs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albumSP = await _context.Albums
                .Include(a => a.SP)
                .FirstOrDefaultAsync(m => m.MaAlbum == id);
            if (albumSP == null)
            {
                return NotFound();
            }

            return View(albumSP);
        }

        // POST: AlbumSPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var albumSP = await _context.Albums.FindAsync(id);
            if (albumSP != null)
            {
                _context.Albums.Remove(albumSP);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlbumSPExists(string id)
        {
            return _context.Albums.Any(e => e.MaAlbum == id);
        }
    }
}
