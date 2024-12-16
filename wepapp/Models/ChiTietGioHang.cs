using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wepapp.Models
{
    [Table("ChiTietGioHang")]
    public class ChiTietGioHang
    {
        [Key]
        [StringLength(10)]
        public string MaGioHang { get; set; }
        [ForeignKey(nameof(MaGioHang))]
        public GioHang? GioHang { get; set; }

        [Key]
        [StringLength(10)] 
        public string MaSP { get; set; }
        [ForeignKey(nameof(MaSP))]
        public SanPham? SanPham { get; set; }

        public int SoLuong { get; set; }

        public ChiTietGioHang() { }
        public ChiTietGioHang(string maGioHang, GioHang? gioHang, string maSP, SanPham? sanPham, int soLuong)
        {
            MaGioHang = maGioHang;
            GioHang = gioHang;
            MaSP = maSP;
            SanPham = sanPham;
            SoLuong = soLuong;
        }
    }
}
