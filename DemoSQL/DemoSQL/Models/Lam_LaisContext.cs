using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoSQL.Models
{
    public partial class Lam_LaisContext : DbContext
    {
        public Lam_LaisContext()
        {
        }

        public Lam_LaisContext(DbContextOptions<Lam_LaisContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ketqua> Ketquas { get; set; } = null!;
        public virtual DbSet<Khoa> Khoas { get; set; } = null!;
        public virtual DbSet<Monhoc> Monhocs { get; set; } = null!;
        public virtual DbSet<Sinhvien> Sinhviens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-MC0HPVFT;Database=Lam_Lais;uid=sa;pwd=1242005;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ketqua>(entity =>
            {
                entity.HasKey(e => new { e.Masv, e.Mamh })
                    .HasName("pk_MASV_MAMH");

                entity.ToTable("KETQUA");

                entity.Property(e => e.Masv)
                    .HasMaxLength(10)
                    .HasColumnName("MASV");

                entity.Property(e => e.Mamh)
                    .HasMaxLength(50)
                    .HasColumnName("MAMH");

                entity.Property(e => e.Diem).HasColumnName("DIEM");

                entity.Property(e => e.Lanthi).HasColumnName("LANTHI");

                entity.HasOne(d => d.MamhNavigation)
                    .WithMany(p => p.Ketquas)
                    .HasForeignKey(d => d.Mamh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KETQUA__MAMH__2E1BDC42");

                entity.HasOne(d => d.MasvNavigation)
                    .WithMany(p => p.Ketquas)
                    .HasForeignKey(d => d.Masv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KETQUA__MASV__2D27B809");
            });

            modelBuilder.Entity<Khoa>(entity =>
            {
                entity.HasKey(e => e.Makhoa)
                    .HasName("PK__KHOA__22F41770AE3E0031");

                entity.ToTable("KHOA");

                entity.Property(e => e.Makhoa)
                    .HasMaxLength(10)
                    .HasColumnName("MAKHOA");

                entity.Property(e => e.Tenkhoa)
                    .HasMaxLength(200)
                    .HasColumnName("TENKHOA");
            });

            modelBuilder.Entity<Monhoc>(entity =>
            {
                entity.HasKey(e => e.Mamh)
                    .HasName("PK__MONHOC__603F69EB71EF5ED0");

                entity.ToTable("MONHOC");

                entity.Property(e => e.Mamh)
                    .HasMaxLength(50)
                    .HasColumnName("MAMH");

                entity.Property(e => e.Sotiet).HasColumnName("SOTIET");

                entity.Property(e => e.Tenmh)
                    .HasMaxLength(100)
                    .HasColumnName("TENMH");
            });

            modelBuilder.Entity<Sinhvien>(entity =>
            {
                entity.HasKey(e => e.Masv)
                    .HasName("PK__SINHVIEN__60228A28167715A8");

                entity.ToTable("SINHVIEN");

                entity.Property(e => e.Masv)
                    .HasMaxLength(10)
                    .HasColumnName("MASV");

                entity.Property(e => e.Hosv)
                    .HasMaxLength(100)
                    .HasColumnName("HOSV");

                entity.Property(e => e.Makhoa)
                    .HasMaxLength(10)
                    .HasColumnName("MAKHOA");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("date")
                    .HasColumnName("NGAYSINH");

                entity.Property(e => e.Phai)
                    .HasMaxLength(5)
                    .HasColumnName("PHAI");

                entity.Property(e => e.Tensv)
                    .HasMaxLength(50)
                    .HasColumnName("TENSV");

                entity.HasOne(d => d.MakhoaNavigation)
                    .WithMany(p => p.Sinhviens)
                    .HasForeignKey(d => d.Makhoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SINHVIEN__MAKHOA__2A4B4B5E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
