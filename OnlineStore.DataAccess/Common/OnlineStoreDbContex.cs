using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Common
{
    public class OnlineStoreDbContex : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public OnlineStoreDbContex() : base()
        {
            
        }

        public OnlineStoreDbContex(DbContextOptions<OnlineStoreDbContex> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OnlineStoreDbContex).Assembly);
        }

        DbSet<ProductAttribute> Attributes { get; set; }
        DbSet<NotificationChannels> NotificationChannels { get; set; }
    }
}
