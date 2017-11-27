using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class dayphoto_reply
    {
        public int dayreply_id { get; set; }
        public int daycomt_id { get; set; }
        public int user_id { get; set; }
        public DateTime replytime { get; set; }
        public string reply_cont { get; set; }
        public int reply_aim { get; set; }
        public int like_count { get; set; }
    }
}
