using web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace web.Data
{
    public class NepremicnineContext : IdentityDbContext<ApplicationUser>
    {
        public NepremicnineContext(DbContextOptions<NepremicnineContext> options) : base(options)
        {
        }

        public DbSet<Stranka>? Stranke { get; set; }
        public DbSet<Agent>? Agenti { get; set; }
        public DbSet<Nepremicnina>? Nepremicnine { get; set; }
        public DbSet<Oglas>? Oglasi { get; set; }
        public DbSet<Ogled>? Ogledi { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            modelBuilder.Entity<Stranka>().ToTable("Stranka");
            modelBuilder.Entity<Agent>().ToTable("Agent");
            modelBuilder.Entity<Nepremicnina>().ToTable("Nepremicnina");
            modelBuilder.Entity<Oglas>().ToTable("Oglas");
            modelBuilder.Entity<Ogled>().ToTable("Ogled");
            
        }
    }
}