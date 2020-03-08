using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class MessageModel
    {
        public int ID { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
        public UserModel User { get; set; }
        public ChannelModel Channels { get; set; }
    }
}
