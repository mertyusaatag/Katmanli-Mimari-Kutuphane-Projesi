using Kutuphane.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane.DataAccess.Concrete
{
    public class KutuphaneDbContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenci { get; set; }
        public DbSet<Kitap> Kitap { get; set; }
        public DbSet<Emanet> Emanet { get; set; }
  
      public KutuphaneDbContext()
        {
            Database.Migrate();
        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source =./BuSeferOldu.sqlite");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Kitap>()
                 .HasMany(e => e.Emanet);



            modelBuilder.Entity<Ogrenci>()
                .HasMany(e => e.Emanet);
              



        }

    }
}
