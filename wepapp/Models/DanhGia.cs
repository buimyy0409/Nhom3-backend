using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wepapp.Models
{
    [Table(nameof(DanhGia))]
    public class DanhGia
    {
        [Key]
        [StringLength(10)]
        public string MaDanhGia { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKH {  get; set; }
        [ForeignKey(nameof(MaKH))]
        public KhachHang? KhachHang { get; set; }

        [Required]
        [StringLength(10)]
        public string MaSP { get; set; }
        [ForeignKey(nameof(MaSP))]
        public SanPham? SanPham { get; set; }

        [Column(TypeName = "text")]
        public string? NoiDung { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string? Hinh {  get; set; }

        public DanhGia() { }
        public DanhGia(string maDanhGia, string maKH, KhachHang? khachHang, string maSP, SanPham? sanPham, string? noiDung, string? hinh)
        {
            MaDanhGia = maDanhGia;
            MaKH = maKH;
            KhachHang = khachHang;
            MaSP = maSP;
            SanPham = sanPham;
            NoiDung = noiDung;
            Hinh = hinh;
        }
    }
}
