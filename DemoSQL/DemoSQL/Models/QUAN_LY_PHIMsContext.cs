using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoSQL.Models
{
    public partial class QUAN_LY_PHIMsContext : DbContext
    {
        public QUAN_LY_PHIMsContext()
        {
        }

        public QUAN_LY_PHIMsContext(DbContextOptions<QUAN_LY_PHIMsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChuDe> ChuDes { get; set; } = null!;
        public virtual DbSet<GiaoPhim> GiaoPhims { get; set; } = null!;
        public virtual DbSet<Phim> Phims { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-MC0HPVFT;Database=QUAN_LY_PHIMs;uid=sa;pwd=1242005;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChuDe>(entity =>
            {
                entity.HasKey(e => e.Macd)
                    .HasName("PK__CHU_DEs__2724820C1148393A");

                entity.ToTable("CHU_DEs");

                entity.Property(e => e.Macd)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Tencd).HasMaxLength(50);
            });

            modelBuilder.Entity<GiaoPhim>(entity =>
            {
                entity.HasKey(e => e.Sttgiao)
                    .HasName("PK__GIAO_PHI__5A41D787D56B2500");

                entity.ToTable("GIAO_PHIMs");

                entity.Property(e => e.Maphim)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Ngaygiao).HasColumnType("date");

                entity.HasOne(d => d.MaphimNavigation)
                    .WithMany(p => p.GiaoPhims)
                    .HasForeignKey(d => d.Maphim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GIAO_PHIM__Maphi__1A14E395");
            });

            modelBuilder.Entity<Phim>(entity =>
            {
                entity.HasKey(e => e.Maphim)
                    .HasName("PK__PHIMs__BC3B06A9F13193A3");

                entity.ToTable("PHIMs");

                entity.Property(e => e.Maphim)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.NgayPh)
                    .HasColumnType("date")
                    .HasColumnName("NgayPH");

                entity.Property(e => e.Tenphim).HasMaxLength(50);

                entity.HasMany(d => d.Macds)
                    .WithMany(p => p.Maphims)
                    .UsingEntity<Dictionary<string, object>>(
                        "PhimChuDe",
                        l => l.HasOne<ChuDe>().WithMany().HasForeignKey("Macd").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__PHIM_CHU_D__Macd__173876EA"),
                        r => r.HasOne<Phim>().WithMany().HasForeignKey("Maphim").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__PHIM_CHU___Maphi__164452B1"),
                        j =>
                        {
                            j.HasKey("Maphim", "Macd").HasName("PHIM_CHU_DE_MA");

                            j.ToTable("PHIM_CHU_DEs");

                            j.IndexerProperty<string>("Maphim").HasMaxLength(4).IsFixedLength();

                            j.IndexerProperty<string>("Macd").HasMaxLength(2).IsFixedLength();
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
