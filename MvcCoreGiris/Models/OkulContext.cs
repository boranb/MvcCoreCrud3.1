using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcCoreGiris.Models
{
    public class OkulContext : DbContext
    {
        public OkulContext(DbContextOptions<OkulContext> options):base(options) 
        {
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=.; database=OkulContext; uid=sa; pwd=123");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kisi>().HasData(
                new Kisi() {Id = 1, KisiAd = "Berkay"},
                new Kisi() {Id = 2, KisiAd = "Boran"}
                );
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Kisi> Kisiler { get; set; }
    }
}
