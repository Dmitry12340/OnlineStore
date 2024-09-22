using Microsoft.EntityFrameworkCore;
using OnlineStore.Contracts.Enums;
using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Extensions;

namespace OnlineStore.DataAccess.NotificationChannel.Configurations
{
    public sealed class NotificationChanelConfiguration : IEntityTypeConfiguration<NotificationChannels>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NotificationChannels> builder)
        {
            builder.ToTable("NotificationChanel");
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(256);

            builder.HasData(Enum.GetValues(typeof(NotificationChannelEnum))
                .Cast<NotificationChannelEnum>()
                .Select(e => new NotificationChannels
                {
                    Id = (int)e,
                    Name = e.GetEnumDescription()
                }));
        }
    }
}
