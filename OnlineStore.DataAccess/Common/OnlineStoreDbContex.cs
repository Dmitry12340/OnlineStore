using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Common
{
    public class OnlineStoreDbContex : DbContext
    {
        public OnlineStoreDbContex()
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
