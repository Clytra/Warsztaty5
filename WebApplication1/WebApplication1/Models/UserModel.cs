using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class UserModel 
    {
        public int ID { get; set; }

        public ICollection<MessageModel> Messages { get; set; }

        public ICollection<ChannelUserModel> ChannelUser { get; set; }
    }
}
