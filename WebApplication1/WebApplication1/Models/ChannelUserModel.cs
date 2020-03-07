using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ChannelUserModel
    {
        public int ID { get; set; }
        public int ChannelID { get; set; }
        public int UserID { get; set; }

        [ForeignKey ("CanalID")]
        public ChannelModel ChannelModel { get; set; }

        [ForeignKey ("UserID")]
        public UserModel UserModel { get; set; }
    }
}
