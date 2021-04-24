using Bogus;
using Microsoft.EntityFrameworkCore;
using System;
using static System.Linq.Enumerable;

namespace MillionAndUp.Data
{
    public class MillionUpDbContext : DbContext
    {
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyImage> PropertyImages { get; set; }
        public DbSet<PropertyTrace> PropertyTraces { get; set; }

        #region OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=./MillionUpDb.db");
        }
        #endregion
        #region OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>(entity =>
            {
                entity.Property(x => x.Name)
                .IsRequired()
                .IsUnicode(false);

                entity.Property(x => x.Address)
                .IsRequired()
                .IsUnicode(false);

                entity.Property(x => x.Photo)
                .IsRequired()
                .IsUnicode(false);

                entity.Property(x => x.Birthday)
                .IsRequired();
            });
            modelBuilder.Entity<Property>(entity =>
            {
                entity.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

                entity.Property(x => x.Address)
                .IsRequired()
                .IsUnicode(false);

                entity.Property(x => x.InternalCode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

                entity.Property(x => x.Price)
                .IsRequired();

                entity.Property(x => x.Year)
                .IsRequired();
            });
            modelBuilder.Entity<PropertyImage>(entity =>
            {
                entity.Property(x => x.FilePath)
                .IsRequired()
                .IsUnicode(false);

                entity.Property(x => x.Enabled)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            });
            modelBuilder.Entity<PropertyTrace>(entity =>
            {
                entity.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

                entity.Property(x => x.SaleDate)
                .IsRequired();

                entity.Property(x => x.Value)
                .IsRequired();

                entity.Property(x => x.Tax)
                .IsRequired();
            });
            modelBuilder.Entity<PropertyTrace>(entity =>
            {
                entity.Property(x => x.SaleDate)
                .IsRequired();

                entity.Property(x => x.Value)
                .IsRequired();
            });
            modelBuilder.Seed();
        }
        #endregion
    }
}