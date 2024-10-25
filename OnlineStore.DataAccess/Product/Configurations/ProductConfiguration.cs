using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Product.Configurations
{
    public sealed class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(x => x.Id);

            builder
                .Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(x => x.Name);


            builder.Property(e => e.Category)
            .HasMaxLength(100);

            builder.Property(e => e.Description)
                .HasMaxLength(500);

            builder.HasMany(p => p.Images)
                .WithOne(i => i.Products)
                .HasForeignKey(i => i.ProductId);

            builder.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(e => e.Price);

            builder.Property(e => e.Quantity);
        }
    }
}
