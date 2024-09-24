using Microsoft.AspNetCore.Identity;

namespace OnlineStore.Domain.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        /// <summary>
        /// Id чата пользователя в telegram
        /// </summary>
        public long TelegramChatId {  get; set; }


        /// <summary>
        /// Каналы уведомления пользователя.
        /// </summary>
        public ICollection<NotificationChannels> NotificationChannels { get; set; } = [];
    }
}
