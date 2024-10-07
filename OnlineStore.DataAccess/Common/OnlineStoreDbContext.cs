using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Common
{
    public class OnlineStoreDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public OnlineStoreDbContext() : base()
        {
            
        }

        public OnlineStoreDbContext(DbContextOptions<OnlineStoreDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OnlineStoreDbContext).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<ProductAttribute> Attributes { get; set; }
        public DbSet<NotificationChannels> NotificationChannels { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
