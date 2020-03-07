using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MessageModel
    {
        public int ID { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
        public UserModel UserModel { get; set; }
        public ChannelModel ChannelModel { get; set; }
    }
}
