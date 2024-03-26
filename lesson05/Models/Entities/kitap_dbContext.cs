using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace lesson05.Models.Entities
{
    public partial class kitap_dbContext : DbContext
    {
        public kitap_dbContext()
        {
        }

        public kitap_dbContext(DbContextOptions<kitap_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Diller> Dillers { get; set; } = null!;
        public virtual DbSet<Iletisim> Iletisims { get; set; } = null!;
        public virtual DbSet<Kitaplar> Kitaplars { get; set; } = null!;
        public virtual DbSet<Turler> Turlers { get; set; } = null!;
        public virtual DbSet<Turlertokitaplar> Turlertokitaplars { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Yayinevleri> Yayinevleris { get; set; } = null!;
        public virtual DbSet<Yazarlar> Yazarlars { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_turkish_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<Diller>(entity =>
            {
                entity.ToTable("diller");

                entity.HasCharSet("latin5")
                    .UseCollation("latin5_turkish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.DilAdi)
                    .HasMaxLength(50)
                    .HasColumnName("dilAdi")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Iletisim>(entity =>
            {
                entity.ToTable("iletisim");

                entity.HasCharSet("latin5")
                    .UseCollation("latin5_turkish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Eposta)
                    .HasMaxLength(100)
                    .HasColumnName("eposta");

                entity.Property(e => e.Goruldu).HasColumnName("goruldu");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .HasColumnName("ip")
                    .IsFixedLength();

                entity.Property(e => e.Konu)
                    .HasMaxLength(150)
                    .HasColumnName("konu");

                entity.Property(e => e.Mesaj)
                    .HasMaxLength(600)
                    .HasColumnName("mesaj");

                entity.Property(e => e.TarihSaat)
                    .HasColumnType("datetime")
                    .HasColumnName("tarihSaat");
            });

            modelBuilder.Entity<Kitaplar>(entity =>
            {
                entity.ToTable("kitaplar");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Adi)
                    .HasMaxLength(200)
                    .HasColumnName("adi")
                    .IsFixedLength()
                    .UseCollation("latin5_turkish_ci")
                    .HasCharSet("latin5");

                entity.Property(e => e.DilId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dilID")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Ozet)
                    .HasMaxLength(5000)
                    .HasColumnName("ozet")
                    .UseCollation("latin5_turkish_ci")
                    .HasCharSet("latin5");

                entity.Property(e => e.Resim)
                    .HasMaxLength(50)
                    .HasColumnName("resim");

                entity.Property(e => e.SayfaSayisi)
                    .HasColumnType("int(11)")
                    .HasColumnName("sayfaSayisi")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.YayinTarihi).HasColumnName("yayinTarihi");

                entity.Property(e => e.YayineviId)
                    .HasColumnType("int(11)")
                    .HasColumnName("yayineviID")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.YazarId)
                    .HasColumnType("int(11)")
                    .HasColumnName("yazarID")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Turler>(entity =>
            {
                entity.ToTable("turler");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Sira)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TurAdi)
                    .HasMaxLength(50)
                    .HasColumnName("turAdi")
                    .IsFixedLength()
                    .UseCollation("latin5_turkish_ci")
                    .HasCharSet("latin5");
            });

            modelBuilder.Entity<Turlertokitaplar>(entity =>
            {
                entity.ToTable("turlertokitaplar");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.KitapId)
                    .HasColumnType("int(11)")
                    .HasColumnName("kitapID")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TurId)
                    .HasColumnType("int(11)")
                    .HasColumnName("turID")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasCharSet("latin5")
                    .UseCollation("latin5_turkish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Yayinevleri>(entity =>
            {
                entity.ToTable("yayinevleri");

                entity.HasCharSet("latin5")
                    .UseCollation("latin5_turkish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Adres)
                    .HasMaxLength(150)
                    .HasColumnName("adres");

                entity.Property(e => e.Sira)
                    .HasColumnType("int(4)")
                    .HasColumnName("sira")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Tel)
                    .HasMaxLength(13)
                    .HasColumnName("tel")
                    .IsFixedLength();

                entity.Property(e => e.YayineviAdi)
                    .HasMaxLength(200)
                    .HasColumnName("yayineviAdi")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Yazarlar>(entity =>
            {
                entity.ToTable("yazarlar");

                entity.HasCharSet("latin5")
                    .UseCollation("latin5_turkish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Adi)
                    .HasMaxLength(100)
                    .HasColumnName("adi")
                    .IsFixedLength();

                entity.Property(e => e.Cinsiyeti).HasColumnName("cinsiyeti");

                entity.Property(e => e.DogumTarihi).HasColumnName("dogumTarihi");

                entity.Property(e => e.DogumYeri)
                    .HasMaxLength(100)
                    .HasColumnName("dogumYeri")
                    .IsFixedLength();

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(100)
                    .HasColumnName("soyadi")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
