using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wepapp.Models
{
    [Table(nameof(CTKM))]
    public class CTKM
    {
        [Key]
        [StringLength(10)]
        public string MaCTKM { get; set; }

        [Required]
        [StringLength(70)]
        public string TenCTKM { get; set; }

        [Column(TypeName = "text")]
        public string NoiDung { get; set; }
        public DateTime NgayBatDau {  get; set; }
        public DateTime NgayKetThuc {  get; set; }

        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        [RegularExpression(@"^(Giảm giá|Miễn phí vận chuyển)$", ErrorMessage = "Giá trị của Loại CTKM phải là 'Giảm giá' hoặc 'Miễn phí vận chuyển'")]
        public string LoaiCTKM { get; set; }
        public int SoTienMuaToiThieu { get; set; }
        public int SoTienDuocGiam {  get; set; }

        public CTKM() { }
        public CTKM(string maCTKM, string tenCTKM, string noiDung, DateTime ngayBatDau, DateTime ngayKetThuc, string loaiCTKM, int soTienMuaToiThieu, int soTienDuocGiam)
        {
            MaCTKM = maCTKM;
            TenCTKM = tenCTKM;
            NoiDung = noiDung;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            LoaiCTKM = loaiCTKM;
            SoTienMuaToiThieu = soTienMuaToiThieu;
            SoTienDuocGiam = soTienDuocGiam;
        }
    }
}
