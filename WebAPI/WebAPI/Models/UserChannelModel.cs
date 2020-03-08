using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class UserChannelModel
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int ChannelID { get; set; }
        [ForeignKey("UserID")]
        public UserModel User { get; set; }
        [ForeignKey("ChannelID")]
        public ChannelModel Channel { get; set; }
    }
}
