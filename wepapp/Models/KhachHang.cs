using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wepapp.Models
{
    [Table(nameof(KhachHang))]
    public class KhachHang
    {
        [Key]
        [StringLength(10)]
        public string MaKH { get; set; }

        [Column(TypeName = "text")]
        public string TenKH { get; set; }

        [Required]
        [StringLength(10)]
        public string TaiKhoan { get; set; }

        [Required]
        [StringLength(10)]
        public string MatKhau { get; set; }
        public DateTime NgaySinh { get; set; }

        [RegularExpression(@"^(Nam|Nữ)$", ErrorMessage = "Giá trị của Giới tính phải là 'Nam' hoặc 'Nữ'")]
        public string GioiTinh { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "nchar(10)")]
        public string SoDienThoai { get; set; }

        [Column(TypeName = "text")]
        public string DiaChiNhanHang { get; set; }

        public KhachHang() { }
        public KhachHang(string maKH, string tenKH, string taiKhoan, string matKhau, DateTime ngaySinh, string gioiTinh, string email, string soDienThoai, string diaChiNhanHang)
        {
            MaKH = maKH;
            TenKH = tenKH;
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            Email = email;
            SoDienThoai = soDienThoai;
            DiaChiNhanHang = diaChiNhanHang;
        }
    }
}
