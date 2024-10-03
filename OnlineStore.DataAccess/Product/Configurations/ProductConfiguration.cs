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

            builder.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(e => e.Category)
                .HasMaxLength(100);
        }
    }
}
