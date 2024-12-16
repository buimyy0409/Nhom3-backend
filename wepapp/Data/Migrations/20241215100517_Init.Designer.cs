﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wepapp.Data;

#nullable disable

namespace wepapp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241215100517_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("wepapp.Models.AlbumSP", b =>
                {
                    b.Property<string>("MaAlbum")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Hinh")
                        .HasColumnType("text");

                    b.Property<string>("MaSP")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("MaAlbum");

                    b.HasIndex("MaSP");

                    b.ToTable("AlbumSP");
                });

            modelBuilder.Entity("wepapp.Models.CTKM", b =>
                {
                    b.Property<string>("MaCTKM")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LoaiCTKM")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SoTienDuocGiam")
                        .HasColumnType("int");

                    b.Property<int>("SoTienMuaToiThieu")
                        .HasColumnType("int");

                    b.Property<string>("TenCTKM")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("MaCTKM");

                    b.ToTable("CTKM");
                });

            modelBuilder.Entity("wepapp.Models.ChiTietDonHang", b =>
                {
                    b.Property<string>("MaSP")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MaDonHang")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaSP", "MaDonHang");

                    b.HasIndex("MaDonHang");

                    b.ToTable("ChiTietDonHang");
                });

            modelBuilder.Entity("wepapp.Models.ChiTietGioHang", b =>
                {
                    b.Property<string>("MaSP")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MaGioHang")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaSP", "MaGioHang");

                    b.HasIndex("MaGioHang");

                    b.ToTable("ChiTietGioHang");
                });

            modelBuilder.Entity("wepapp.Models.DanhGia", b =>
                {
                    b.Property<string>("MaDanhGia")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Hinh")
                        .HasColumnType("text");

                    b.Property<string>("MaKH")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MaSP")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("NoiDung")
                        .HasColumnType("text");

                    b.HasKey("MaDanhGia");

                    b.HasIndex("MaKH");

                    b.HasIndex("MaSP");

                    b.ToTable("DanhGia");
                });

            modelBuilder.Entity("wepapp.Models.DonHang", b =>
                {
                    b.Property<string>("MaDonHang")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DiaChiNhanHang")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MaCTKM")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MaKH")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("PhuongThucThanhToan")
                        .HasColumnType("int");

                    b.Property<int>("TongTien")
                        .HasColumnType("int");

                    b.HasKey("MaDonHang");

                    b.HasIndex("MaCTKM");

                    b.HasIndex("MaKH");

                    b.ToTable("DonHang");
                });

            modelBuilder.Entity("wepapp.Models.GioHang", b =>
                {
                    b.Property<string>("MaGioHang")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MaKH")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("MaGioHang");

                    b.HasIndex("MaKH");

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("wepapp.Models.KhachHang", b =>
                {
                    b.Property<string>("MaKH")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DiaChiNhanHang")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<string>("TaiKhoan")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenKH")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("MaKH");

                    b.HasIndex("TaiKhoan")
                        .IsUnique();

                    b.ToTable("KhachHang");

                    b.HasData(
                        new
                        {
                            MaKH = "KH001",
                            DiaChiNhanHang = "so 1, duong 2, phuong 3, quan 4",
                            Email = "abc@gmail.com",
                            GioiTinh = "Nam",
                            MatKhau = "accountTes",
                            NgaySinh = new DateTime(2000, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoDienThoai = "3746247823",
                            TaiKhoan = "KH001",
                            TenKH = "Nguyen Van A"
                        });
                });

            modelBuilder.Entity("wepapp.Models.LoaiSP", b =>
                {
                    b.Property<string>("MaLoai")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.HasKey("MaLoai");

                    b.ToTable("LoaiSP");
                });

            modelBuilder.Entity("wepapp.Models.SanPham", b =>
                {
                    b.Property<string>("MaSP")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ChatLieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gia")
                        .HasColumnType("int");

                    b.Property<int>("GiaKhuyenMai")
                        .HasColumnType("int");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhChinh")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MaLoai")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MauSac")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Mota")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaSP");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("wepapp.Models.AlbumSP", b =>
                {
                    b.HasOne("wepapp.Models.SanPham", "SP")
                        .WithMany()
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SP");
                });

            modelBuilder.Entity("wepapp.Models.ChiTietDonHang", b =>
                {
                    b.HasOne("wepapp.Models.DonHang", "DonHang")
                        .WithMany()
                        .HasForeignKey("MaDonHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wepapp.Models.SanPham", "SP")
                        .WithMany()
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DonHang");

                    b.Navigation("SP");
                });

            modelBuilder.Entity("wepapp.Models.ChiTietGioHang", b =>
                {
                    b.HasOne("wepapp.Models.GioHang", "GioHang")
                        .WithMany()
                        .HasForeignKey("MaGioHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wepapp.Models.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GioHang");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("wepapp.Models.DanhGia", b =>
                {
                    b.HasOne("wepapp.Models.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("MaKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wepapp.Models.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("wepapp.Models.DonHang", b =>
                {
                    b.HasOne("wepapp.Models.CTKM", "CTKM")
                        .WithMany()
                        .HasForeignKey("MaCTKM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wepapp.Models.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("MaKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CTKM");

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("wepapp.Models.GioHang", b =>
                {
                    b.HasOne("wepapp.Models.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("MaKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");
                });
#pragma warning restore 612, 618
        }
    }
}
