using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace lesson04.Models.Entities
{
    public partial class kahveContext : DbContext
    {
        public kahveContext()
        {
        }

        public kahveContext(DbContextOptions<kahveContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Anasayfa> Anasayfas { get; set; } = null!;
        public virtual DbSet<Hakkimizdum> Hakkimizda { get; set; } = null!;
        public virtual DbSet<Iletisim> Iletisims { get; set; } = null!;
        public virtual DbSet<Kullanicilar> Kullanicilars { get; set; } = null!;
        public virtual DbSet<Magaza> Magazas { get; set; } = null!;
        public virtual DbSet<Magazasaat> Magazasaats { get; set; } = null!;
        public virtual DbSet<Urunler> Urunlers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_turkish_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<Anasayfa>(entity =>
            {
                entity.ToTable("anasayfa");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AltBaslik)
                    .HasMaxLength(250)
                    .HasColumnName("altBaslik")
                    .IsFixedLength();

                entity.Property(e => e.AltIcerik)
                    .HasMaxLength(6000)
                    .HasColumnName("altIcerik");

                entity.Property(e => e.Foto)
                    .HasMaxLength(50)
                    .HasColumnName("foto")
                    .IsFixedLength();

                entity.Property(e => e.Link)
                    .HasMaxLength(50)
                    .HasColumnName("link")
                    .IsFixedLength();

                entity.Property(e => e.UstBaslik)
                    .HasMaxLength(250)
                    .HasColumnName("ustBaslik");

                entity.Property(e => e.UstIcerik)
                    .HasMaxLength(6000)
                    .HasColumnName("ustIcerik");
            });

            modelBuilder.Entity<Hakkimizdum>(entity =>
            {
                entity.ToTable("hakkimizda");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(250)
                    .HasColumnName("baslik")
                    .IsFixedLength();

                entity.Property(e => e.Foto)
                    .HasMaxLength(50)
                    .HasColumnName("foto")
                    .IsFixedLength();

                entity.Property(e => e.Icerik)
                    .HasColumnType("text")
                    .HasColumnName("icerik");

                entity.Property(e => e.UstBaslik)
                    .HasMaxLength(250)
                    .HasColumnName("ustBaslik")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Iletisim>(entity =>
            {
                entity.ToTable("iletisim");

                entity.UseCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasMaxLength(250)
                    .HasColumnName("ad");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .HasColumnName("email");

                entity.Property(e => e.Mesaj)
                    .HasColumnType("text")
                    .HasColumnName("mesaj");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Kullanicilar>(entity =>
            {
                entity.ToTable("kullanicilar");

                entity.UseCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Kadi)
                    .HasMaxLength(50)
                    .HasColumnName("kadi")
                    .IsFixedLength();

                entity.Property(e => e.Parola)
                    .HasMaxLength(50)
                    .HasColumnName("parola")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Magaza>(entity =>
            {
                entity.ToTable("magaza");

                entity.UseCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Adres)
                    .HasMaxLength(250)
                    .HasColumnName("adres")
                    .HasDefaultValueSql("'0'")
                    .IsFixedLength();

                entity.Property(e => e.AnaBaslik)
                    .HasMaxLength(500)
                    .HasColumnName("anaBaslik")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(20)
                    .HasColumnName("telefon")
                    .HasDefaultValueSql("'0'")
                    .IsFixedLength();

                entity.Property(e => e.UstBaslik)
                    .HasMaxLength(50)
                    .HasColumnName("ustBaslik")
                    .HasDefaultValueSql("'0'")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Magazasaat>(entity =>
            {
                entity.ToTable("magazasaat");

                entity.UseCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Gun)
                    .HasMaxLength(50)
                    .HasColumnName("gun")
                    .IsFixedLength();

                entity.Property(e => e.Saat)
                    .HasMaxLength(50)
                    .HasColumnName("saat")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Urunler>(entity =>
            {
                entity.ToTable("urunler");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Aktif)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("aktif");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(250)
                    .HasColumnName("baslik")
                    .IsFixedLength();

                entity.Property(e => e.Foto)
                    .HasMaxLength(50)
                    .HasColumnName("foto")
                    .IsFixedLength();

                entity.Property(e => e.Icerik)
                    .HasColumnType("text")
                    .HasColumnName("icerik");

                entity.Property(e => e.Sira)
                    .HasColumnType("int(11)")
                    .HasColumnName("sira");

                entity.Property(e => e.UstBaslik)
                    .HasMaxLength(250)
                    .HasColumnName("ustBaslik")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
