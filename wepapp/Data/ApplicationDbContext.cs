using Microsoft.EntityFrameworkCore;
using wepapp.Models;

namespace wepapp.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _config;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration config)
            : base(options)
        {
            _config = config;
        }

        public DbSet<AlbumSP> Albums { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public DbSet<ChiTietGioHang> ChiTietGioHangs { get; set; }
        public DbSet<CTKM> CTKM { get; set; }
        public DbSet<DanhGia> DanhGia { get; set; }
        public DbSet<DonHang> DonHang { get; set; }
        public DbSet<GioHang> GioHang { get; set; }
        public DbSet<KhachHang> KhachHang { get; set;}
        public DbSet<LoaiSP> LoaiSP { get; set; }
        public DbSet<SanPham> SanPham { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ChiTietGioHang>().HasKey(x => new {x.MaSP, x.MaGioHang });
            builder.Entity<ChiTietDonHang>().HasKey(x => new { x.MaSP, x.MaDonHang });
            builder.Entity<KhachHang>().HasIndex(x => x.TaiKhoan).IsUnique();
            builder.Entity<KhachHang>().HasData(new KhachHang
            {
                MaKH = "KH001",
                TenKH = "Nguyen Van A",
                TaiKhoan = "KH001",
                MatKhau = "accountTes",
                NgaySinh = new DateTime(2000, 12, 13),
                GioiTinh = "Nam",
                SoDienThoai = "3746247823",
                DiaChiNhanHang = "so 1, duong 2, phuong 3, quan 4",
                Email = "abc@gmail.com"
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string ConnectionStrings = _config.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            optionsBuilder.UseSqlServer(ConnectionStrings);
        }
    }
}
