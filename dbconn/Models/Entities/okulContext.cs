using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dbconn.Models.Entities
{
    public partial class okulContext : DbContext
    {
        public okulContext()
        {
        }

        public okulContext(DbContextOptions<okulContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ogrenci> Ogrencis { get; set; } = null!;
        public virtual DbSet<Sinif> Sinifs { get; set; } = null!;
        public virtual DbSet<Table1> Table1s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;user=root;database=okul;default command timeout=120;sslmode=none", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.36-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<Ogrenci>(entity =>
            {
                entity.ToTable("ogrenci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .HasColumnName("adi")
                    .IsFixedLength();

                entity.Property(e => e.Cinsiyet)
                    .HasColumnType("int(11)")
                    .HasColumnName("cinsiyet");

                entity.Property(e => e.Dtarihi).HasColumnName("dtarihi");

                entity.Property(e => e.SinifId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sinif_id");

                entity.Property(e => e.Soyad)
                    .HasMaxLength(30)
                    .HasColumnName("soyad")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sinif>(entity =>
            {
                entity.ToTable("sinif");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Aciklama)
                    .HasColumnType("text")
                    .HasColumnName("aciklama");

                entity.Property(e => e.Adi)
                    .HasMaxLength(30)
                    .HasColumnName("adi")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.ToTable("table1");

                entity.Property(e => e.Id).HasColumnType("int(10)");

                entity.Property(e => e.Ad)
                    .HasMaxLength(255)
                    .HasColumnName("ad");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Sehir)
                    .HasMaxLength(255)
                    .HasColumnName("sehir");

                entity.Property(e => e.Soyad)
                    .HasMaxLength(255)
                    .HasColumnName("soyad");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(255)
                    .HasColumnName("telefon");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
