using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wepapp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLoaiSP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaLoai",
                table: "SanPham",
                column: "MaLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_LoaiSP_MaLoai",
                table: "SanPham",
                column: "MaLoai",
                principalTable: "LoaiSP",
                principalColumn: "MaLoai",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_LoaiSP_MaLoai",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_MaLoai",
                table: "SanPham");
        }
    }
}
