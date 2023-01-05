using Microsoft.EntityFrameworkCore;
using SelfieAWookie.Core.Models;

namespace SelfieAWookie.Web.UI.AppCode.Models
{
    public class DefaultDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Avant type configuration
            //modelBuilder.Entity<Selfie>().ToTable("selfie");
            //modelBuilder.Entity<Selfie>().HasKey(x => x.Id);
            // modelBuilder.Entity<Selfie>().Property(item => item.Titre).HasMaxLength(255);

            // Apres type configuration
            modelBuilder.ApplyConfiguration(new SelfieEntityTypeConfiguration());

            // Pour chaque table à faire, si besoin
        }

        public DefaultDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected DefaultDbContext() : base()
        {
        }

        public DbSet<Selfie> Selfies { get; set; }
    }
}
