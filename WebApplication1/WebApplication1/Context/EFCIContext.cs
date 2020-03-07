using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class EFCIContext : IdentityDbContext
    {
        public EFCIContext(DbContextOptions<EFCIContext> options) : base(options) { }

        DbSet<MessageModel> Messages { get; set; }
        DbSet<ChannelModel> Channels { get; set; }
        DbSet<UserModel> Users { get; set; }
    }
}
