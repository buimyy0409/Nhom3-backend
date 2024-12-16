using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wepapp.Models
{
    [Table(nameof(DonHang))]
    public class DonHang
    {
        [Key]
        [StringLength(10)]
        public string MaDonHang { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKH { get; set; }
        [ForeignKey(nameof(MaKH))]
        public KhachHang? KhachHang { get; set; }

        [Required]
        [StringLength(10)]
        public string MaCTKM { get; set; }
        [ForeignKey(nameof(MaCTKM))]
        public CTKM? CTKM { get; set; }

        [Display(Name = "Tong tien")]
        public int TongTien { get; set; }
        public int PhuongThucThanhToan { get; set; }

        [Required]
        [Column(TypeName = "text")]
        [Display(Name = "Dia chi nhan hang")]
        public string DiaChiNhanHang { get; set; }

        public DonHang() { }
        public DonHang(string maDonHang, string maKH, KhachHang? khachHang, string maCTKM, CTKM? cTKM, int tongTien, int phuongThucThanhToan, string diaChiNhanHang)
        {
            MaDonHang = maDonHang;
            MaKH = maKH;
            KhachHang = khachHang;
            MaCTKM = maCTKM;
            CTKM = cTKM;
            TongTien = tongTien;
            PhuongThucThanhToan = phuongThucThanhToan;
            DiaChiNhanHang = diaChiNhanHang;
        }
    }
}
