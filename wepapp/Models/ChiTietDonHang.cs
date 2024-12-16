using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wepapp.Models
{
    [Table("ChiTietDonHang")]
    public class ChiTietDonHang
    {
        [Key]
        [StringLength(10)]
        public string MaDonHang { get; set; }
        [ForeignKey(nameof(MaDonHang))]
        public DonHang? DonHang { get; set; }

        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }
        [ForeignKey(nameof(MaSP))]
        public SanPham? SP { get; set; }

        public int SoLuong { get; set; }

        public ChiTietDonHang() { }
        public ChiTietDonHang(string maDonHang, DonHang? donHang, string maSP, SanPham? sP, int soLuong)
        {
            MaDonHang = maDonHang;
            DonHang = donHang;
            MaSP = maSP;
            SP = sP;
            SoLuong = soLuong;
        }
    }
}
