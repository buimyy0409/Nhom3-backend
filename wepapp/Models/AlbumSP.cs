using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wepapp.Models
{
    [Table("AlbumSP")]
    public class AlbumSP
    {
        [Key]
        [StringLength(10)]
        public string MaAlbum {  get; set; }

        [Required]
        [StringLength(10)]
        public string MaSP { get; set; }
        [ForeignKey(nameof(MaSP))]
        public SanPham? SP { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string? Hinh { get; set; }
        public AlbumSP() {  }
        public AlbumSP(string maAlbum, string maSP, SanPham? sP, string? hinh)
        {
            MaAlbum = maAlbum;
            MaSP = maSP;
            SP = sP;
            Hinh = hinh;
        }
    }
}
