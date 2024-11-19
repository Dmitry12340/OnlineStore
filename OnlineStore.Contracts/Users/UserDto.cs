using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Contracts.Users
{
    public sealed class UserDto
    {
        public int Id { get; set; }
        public long TelegramChatId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
