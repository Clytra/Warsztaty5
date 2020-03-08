using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Context;

namespace WebAPI.Models
{
    public class EFRepository : IRepository
    {
        private EFContext context;

        public EFRepository(EFContext ctx)
        {
            context = ctx;
        }

        public IQueryable<ChannelModel> Channels => context.Channels;
        public IQueryable<MessageModel> Messages => context.Messages;

        public void SaveChannel(ChannelModel channelModel)
        {
            if (channelModel.ID == 0)
            {
                context.Channels.Add(channelModel);
            }
            else
            {
                ChannelModel dbEntry = context.Channels
                    .FirstOrDefault(p => p.ID == channelModel.ID);
                if (dbEntry != null)
                {
                    dbEntry.Name = channelModel.Name;
                    dbEntry.Color = channelModel.Color;
                    dbEntry.CreatedByUserId = channelModel.CreatedByUserId;
                }
            }
            context.SaveChanges();
        }

        public void SaveMessage(MessageModel messageModel)
        {
            if (messageModel.ID == 0)
            {
                context.Messages.Add(messageModel);
            }
            else
            {
                MessageModel dbEntry = context.Messages
                    .FirstOrDefault(p => p.ID == messageModel.ID);
                if (dbEntry != null)
                {
                    dbEntry.Message = messageModel.Message;
                    dbEntry.Created = messageModel.Created;
                }
            }
            context.SaveChanges();
        }

        public void SaveUserChannel(UserChannelModel userChannelModel)
        {

        }

        public ChannelModel DeleteChannel(int ID)
        {
            ChannelModel dbEntry = context.Channels
                .FirstOrDefault(p => p.ID == ID);
            if (dbEntry != null)
            {
                context.Channels.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public MessageModel DeleteMessage(int ID)
        {
            MessageModel dbEntry = context.Messages
                .FirstOrDefault(p => p.ID == ID);
            if (dbEntry != null)
            {
                context.Messages.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
