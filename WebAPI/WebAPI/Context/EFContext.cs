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

        DbSet<MessageModel> Messages { get; set; }
        DbSet<ChannelModel> Chanels { get; set; }
        DbSet<UserModel> Users { get; set; }
        DbSet<UserChannelModel> UsersChannels { get; set; }
    }
}
