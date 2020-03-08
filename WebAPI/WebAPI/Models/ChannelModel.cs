using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class ChannelModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int CreatedByUserId { get; set; }
        public ICollection<UserChannelModel> UserChannel { get; set; }
        public ICollection<MessageModel> Messages { get; set; }
    }
}
