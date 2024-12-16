using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wepapp.Models
{
    [Table(nameof(LoaiSP))]
    public class LoaiSP
    {
        [Key]
        [StringLength(10)]
        public string MaLoai { get; set; }

        [Column(TypeName = "text")]
        public string TenLoai { get; set; }

        [Column(TypeName = "nchar(10)")]
        [RegularExpression(@"^(Hiển thị|Ẩn)$", ErrorMessage = "Giá trị của TrangThai phải là 'Hiển thị' hoặc 'Ẩn'")]
        public string? TrangThai { get; set; } = "Hiển thị";
        public LoaiSP() { }
        public LoaiSP(string maLoai, string tenLoai, string? trangThai)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
            TrangThai = trangThai;
        }
    }
}
