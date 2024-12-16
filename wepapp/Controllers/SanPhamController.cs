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
    public class SanPhamController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SanPhamController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SanPham
        public async Task<IActionResult> Index()
        {
            return View(await _context.SanPham.ToListAsync());
        }

        // GET: SanPham/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPham
                .FirstOrDefaultAsync(m => m.MaSP == id);
            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }

        // GET: SanPham/Create
        public IActionResult Create()
        {
            var danhSachLoaiSP = _context.LoaiSP.ToList();
            ViewData["LoaiSPs"] = new SelectList(danhSachLoaiSP, "MaLoai", "TenLoai");

            string[] danhSachTrangThai = ["Hiển thị", "Ẩn"];
            ViewData["TrangThai"] = danhSachTrangThai;
            return View();
        }

        // POST: SanPham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaLoai,SKU,TenSP,MauSac,ChatLieu,GioiTinh,Gia,TrangThai,Mota,GiaKhuyenMai")] SanPham sanPham, IFormFile file)
        {
            var countSP = _context.SanPham.Count();
            StringBuilder sb = new StringBuilder();
            sb.Append("SP");
            sb.Append((countSP + 1).ToString("000000"));

            sanPham.MaSP = sb.ToString();

            var url = UploadImage(file);
            sanPham.HinhChinh = url;

            _context.Add(sanPham);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: SanPham/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPham.FindAsync(id);
            if (sanPham == null)
            {
                return NotFound();
            }
            return View(sanPham);
        }

        // POST: SanPham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaSP,MaLoai,SKU,TenSP,MauSac,ChatLieu,HinhChinh,GioiTinh,Gia,TrangThai,Mota,NgayTao,GiaKhuyenMai")] SanPham sanPham, IFormFile file)
        {
            if (id != sanPham.MaSP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var url = UploadImage(file);
                    sanPham.HinhChinh = url;

                    _context.Update(sanPham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SanPhamExists(sanPham.MaSP))
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
            return View(sanPham);
        }

        // GET: SanPham/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPham
                .FirstOrDefaultAsync(m => m.MaSP == id);
            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }

        // POST: SanPham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var sanPham = await _context.SanPham.FindAsync(id);
            if (sanPham != null)
            {
                _context.SanPham.Remove(sanPham);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public string UploadImage(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                // Tạo một tên file duy nhất để tránh trùng lặp
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", fileName);

                // Tạo thư mục nếu chưa có
                var directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Lưu file vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                return fileName;
            }

            return "";
        }
        public IActionResult Indexx()
        {
            var sanPhams = _context.SanPham.Include(sp => sp.MaLoai).ToList(); // Eager loading LoaiSP
            return View(sanPhams);
        }
        private bool SanPhamExists(string id)
        {
            return _context.SanPham.Any(e => e.MaSP == id);
        }
    }
}
