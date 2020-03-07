using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    interface IRepository
    {
        IQueryable<MessageModel> Messages { get; }
        IQueryable<ChannelModel> Channels { get; }

        void SaveCanal(ChannelModel channelModel);
        void SaveMessage(MessageModel messageModel);

        ChannelModel DeleteChannel(int ID);

        MessageModel DeleteMessage(int ID);
    }
}
