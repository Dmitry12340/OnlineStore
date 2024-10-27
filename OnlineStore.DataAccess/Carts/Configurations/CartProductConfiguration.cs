using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Carts.Configurations
{
    public sealed class CartProductConfiguration : IEntityTypeConfiguration<CartProduct>
    {
        public void Configure(EntityTypeBuilder<CartProduct> builder)
        {
            builder.ToTable("cartproduct");

            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.Cart)
                .WithMany()
                .HasForeignKey(t => t.CartId)
                .IsRequired(true);

            builder.HasOne(t => t.Products)
                .WithMany()
                .HasForeignKey(t => t.ProductId)
                .IsRequired(true);
        }
    }
}
