using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wepapp.Models
{
    [Table(nameof(GioHang))]
    public class GioHang
    {
        [Key]
        [StringLength(10)]
        public string MaGioHang { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKH { get; set; }
        [ForeignKey(nameof(MaKH))]
        public KhachHang? KhachHang { get; set; }

        public GioHang() { }
        public GioHang(string maGioHang, string maKH, KhachHang? khachHang)
        {
            MaGioHang = maGioHang;
            MaKH = maKH;
            KhachHang = khachHang;
        }
    }
}
