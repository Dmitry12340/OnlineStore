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

        DbSet<ProductAttribute> Attributes { get; set; }
        DbSet<NotificationChannels> NotificationChannels { get; set; }
        DbSet<Domain.Entities.Product> Products { get; set; }
    }
}
