using Microsoft.EntityFrameworkCore;
using Pharmacy.Models;

namespace Pharmacy.Data
{
    public class PharmaciyDbContext : DbContext
    {
        public DbSet<Drugstore> Pharmacies { get; set; }

        public DbSet<GenericMedicament> GenericMedicaments { get; set; }

        public DbSet<DrugMedicament> DrugMedicaments { get; set; }

        public DbSet<PurchasedAndSoldDrugMedicament> PurchasedAndSoldDrugs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer(ConnectionConfiguration.ConnectionString);
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //  builder.ApplyConfiguration(new UserRoleEntityConfiguration());
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

    }
}
