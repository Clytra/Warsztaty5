using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CanalModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public ICollection<MessageModel> Messages { get; set; }
        public ICollection<CanalUserModel> CanalUser { get; set; }
    }
}
