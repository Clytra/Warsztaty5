using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public interface IRepository
    {
        IQueryable<ChannelModel> Channels { get; }
        IQueryable<MessageModel> Messages { get; }

        void SaveChannel(ChannelModel channelModel);
        void SaveMessage(MessageModel messageModel);

        ChannelModel DeleteChannel(int ID);
        MessageModel DeleteMessage(int ID);
    }
}
