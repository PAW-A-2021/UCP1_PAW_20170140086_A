using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataVaksin.Models
{
    public partial class DataVaksinContext : DbContext
    {
        public DataVaksinContext()
        {
        }

        public DataVaksinContext(DbContextOptions<DataVaksinContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adminn> Adminn { get; set; }
        public virtual DbSet<DataAnggota> DataAnggota { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<User> User { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adminn>(entity =>
            {
                entity.HasKey(e => e.Jabatan);

                entity.Property(e => e.Nama)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataAnggota>(entity =>
            {
                entity.HasKey(e => e.Nik);

                entity.Property(e => e.Nik).HasColumnName("NIK");

                entity.Property(e => e.Alamat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Foto).HasColumnType("image");

                entity.Property(e => e.JenisKelamin)
                    .HasColumnName("Jenis_Kelamin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JenisVaksin)
                    .HasColumnName("Jenis_Vaksin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nama)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pekerjaan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempatTanggalLahir)
                    .HasColumnName("Tempat_Tanggal_Lahir")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Umur)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.Property(e => e.Jabatan).HasMaxLength(10);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Nama);

                entity.Property(e => e.Nik)
                    .HasColumnName("NIK")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
