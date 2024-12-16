using Microsoft.AspNetCore.Mvc;
using wepapp.Models;
using System.Linq;
using wepapp.Data;

namespace wepapp.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly ApplicationDbContext _context;
        public AccountController(ILogger<AccountController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context =  context;
        }

        // GET: Account/Login
        public IActionResult Login()
        {
            if (HttpContext.Session.TryGetValue("Username", out byte[] value))
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string username, string password)
        {
            var user = _context.KhachHang.FirstOrDefault(u => u.TaiKhoan == username && u.MatKhau == password);

            if (user != null)
            {
                // Lưu thông tin người dùng vào Session
                HttpContext.Session.SetString("Username", user.TaiKhoan);

                // Chuyển hướng đến trang chủ
                TempData["success"] = "Đăng nhập thành công";
                return RedirectToAction("Index", "Home");
            }

            ViewBag.ErrorMessage = "Tên đăng nhập hoặc mật khẩu không đúng.";
            return View();
        }

        // GET: Account/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterAsync(KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                var user = _context.KhachHang.ToList();
                // Kiểm tra nếu tên người dùng đã tồn tại
                if (user.Any(u => u.TaiKhoan == khachHang.TaiKhoan))
                {
                    ViewBag.ErrorMessage = "Tên người dùng đã tồn tại.";
                    return View();
                }

                // Lưu người dùng mới vào danh sách
                _context.KhachHang.Add(khachHang);
                await _context.SaveChangesAsync();

                // Chuyển hướng người dùng đến trang đăng nhập
                return RedirectToAction("Login");
            }

            return View();
        }

        // GET: Account/Logout
        public IActionResult Logout()
        {
            // Xóa thông tin người dùng khỏi Session
            HttpContext.Session.Remove("Username");

            return RedirectToAction("Login");
        }
    }
}
