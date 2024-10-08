using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.ProductImage.Configurations
{
    public sealed class ProductImageConfiguration : IEntityTypeConfiguration<ProductImages>
    {
        public void Configure(EntityTypeBuilder<ProductImages> builder)
        {
            builder.ToTable("ProductImages");

            builder.HasKey(x => x.Id);

            builder
                .Property(e => e.Path)
                .IsRequired();

            builder
                .Property(e => e.ProductId)
                .IsRequired();
        }
    }
}
