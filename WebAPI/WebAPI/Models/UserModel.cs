using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class UserModel : IdentityUser
    {
        public ICollection<UserChannelModel> UserChannel { get; set; }
        public ICollection<MessageModel> Messages { get; set; }
    }
}
