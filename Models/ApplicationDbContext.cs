using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Proje.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicaitonUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Arac> arac { get; set; }
        public DbSet<AracAidiyet> aracAidiyet { get; set; }
        public DbSet<AracBakim> aracBakim { get; set; }
        public DbSet<AracKategori> aracKategori { get; set; }
        public DbSet<AracKaza> aracKaza { get; set; }
        public DbSet<AracMarka> aracMarka { get; set;}
        public DbSet<AracModel> aracModel { get; set; }
        public DbSet<AracZimmet> aracZimmet { get; set; }
        public DbSet<AracSivilPlaka> aracSivilPlaka { get; set; }
        public DbSet<AracVitesTipi> aracVitesTipi { get; set; }
        public DbSet<AracYakit> aracYakit { get; set;}

        public DbSet<Demirbas> demirbas { get; set; }
        public DbSet<DemirbasCinsi> demirbasCins { get; set; }
        public DbSet<DemirbasMarka> demirbasMarka { get; set; }
        public DbSet<DemirbasModel> demirbasModel { get; set; }
        public DbSet<DemirbasZimmet> demirbasZimmet { get; set; }

        public DbSet<Buro> buro { get; set; }
        public DbSet<Personel> personel { get; set; }
        public DbSet<Renk> renk { get; set; }
        public DbSet<Resimler> resimler { get; set; }
        public DbSet<Rutbe> rutbe { get; set; }

        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Town> Town { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Neighborhood> Neighborhood { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AracZimmet>()
                .HasOne(a => a.AracTeslim)
                .WithMany(a => a.AracZimmetTeslim).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<AracZimmet>()
                .HasOne(a => a.AracTesellum)
                .WithMany(a => a.AracZimmetTesellum).OnDelete(DeleteBehavior.ClientSetNull);
            
            builder.Entity<DemirbasZimmet>()
                .HasOne(a => a.DemirbasTeslim)
                .WithMany(a => a.DemirbasZimmetTeslim).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<DemirbasZimmet>()
                .HasOne(a => a.DemirbasTesellum)
                .WithMany(a => a.DemirbasZimmetTesellum).OnDelete(DeleteBehavior.ClientSetNull);
            
            base.OnModelCreating(builder);
        }
    }
}
