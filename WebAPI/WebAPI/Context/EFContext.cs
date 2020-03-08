using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Context
{
    public class EFContext : IdentityDbContext<UserModel>
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
        }

        public DbSet<MessageModel> Messages { get; set; }
        public DbSet<ChannelModel> Channels { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<UserChannelModel> UsersChannels { get; set; }
    }
}
